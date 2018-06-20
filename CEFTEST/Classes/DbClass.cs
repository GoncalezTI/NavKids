using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace NavKids {

    public static class DbClass {

        private static string path = "Data Source = DataBase.db";

        //Usuario

        public static int getId(string usuario) {
            int ret = -1;
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT Id FROM Usuarios WHERE Usuario = @usuario", conn)) {
                    comm.Parameters.AddWithValue("@usuario", usuario);
                    conn.Open();
                    ret = Convert.ToInt32(comm.ExecuteScalar());
                }
            }
            return ret;
        }

        public static string getPass(int id) {
            string pass = null;
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT senha FROM usuario WHERE id = @Id", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    pass = Convert.ToString(comm.ExecuteScalar());
                }
            }
            return pass;
        }

        public static bool VerifyUser(string usuario, string senha) {
            bool ret = false;
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT 'True' FROM usuarios WHERE Usuario = @usuario AND Senha = @senha", conn)) {
                    comm.Parameters.AddWithValue("@usuario", usuario);
                    comm.Parameters.AddWithValue("@senha", senha);
                    conn.Open();
                    ret = Convert.ToBoolean(comm.ExecuteScalar());
                    //MessageBox.Show("" + ret.ToString());
                }
                return ret;
            }
        }

        public static string[] getUsers() {
            List<string> arrayDi = new List<string>();
            string[] ret = new string[] { "Sem Dados" };
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT Usuario FROM Usuarios", conn)) {
                    conn.Open();
                    using (SQLiteDataReader reader = comm.ExecuteReader()) {
                        while (reader.Read()) {
                            arrayDi.Add(reader["Usuario"].ToString());
                        }
                    }
                }
            }
            ret = arrayDi.ToArray();
            return ret;
        }

        public static bool updatePass(int id, string senha) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("UPDATE Usuarios SET senha = @senha WHERE Id = @Id ", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    comm.Parameters.AddWithValue("@senha", senha);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        //MessageBox.Show("Senha alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    return false;
                }
            }
        }

        public static List<CUsuario> GetUsers() {
            List<CUsuario> arrayDi = new List<CUsuario>();

            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Usuarios", conn)) {
                    conn.Open();
                    using (SQLiteDataReader reader = comm.ExecuteReader()) {
                        while (reader.Read()) {
                            //arrayDi.Add(reader["Usuario"].ToString);
                            int id = int.Parse(reader["Id"].ToString());

                            arrayDi.Add(new CUsuario() {
                                Id = int.Parse(reader["Id"].ToString()),
                                Usuario = reader["Usuario"].ToString(),
                                Senha = reader["Senha"].ToString(),
                                Administrador = bool.Parse(reader["Administrador"].ToString()),
                                DiasSemana = new bool[]{
                                    bool.Parse(reader["Domingo"].ToString()),
                                    bool.Parse(reader["Segunda"].ToString()),
                                    bool.Parse(reader["Terca"].ToString()),
                                    bool.Parse(reader["Quarta"].ToString()),
                                    bool.Parse(reader["Quinta"].ToString()),
                                    bool.Parse(reader["Sexta"].ToString()),
                                    bool.Parse(reader["Sabado"].ToString())
                                },
                                NivelJogo = reader["NivelQuestoes"].ToString(),
                                TempoMaxUso = reader["TempoMaxUso"].ToString(),
                                TempoUsado = int.Parse(reader["TempoUsado"].ToString()),
                                UltimaVezUsado = reader["UltimaVezUsado"].ToString(),
                                Historico = GetHist(id),
                                Sites = getSites(id),
                                SitesPermitidos = GetSites(id)
                            });

                        }
                    }
                }
            }
            return arrayDi;
        }

        public static bool setUser(string usuario, string senha, bool admin) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("INSERT INTO Usuarios(Usuario, Senha, Administrador) VALUES (@usuario,@senha,@admin)", conn)) {
                    comm.Parameters.AddWithValue("@admin", admin);
                    comm.Parameters.AddWithValue("@senha", senha);
                    comm.Parameters.AddWithValue("@usuario", usuario);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        public static bool SetUser(CUsuario usuario) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("INSERT INTO Usuarios(Usuario, Senha, Administrador,Segunda,Terca,Quarta,Quinta,Sexta,Sabado,Domingo,TempoMaxUso) VALUES (@usuario,@senha,@admin,@segunda,@terca,@quarta,@quinta,@sexta,@sabado,@domingo,@tempoMaxUso)", conn)) {
                    comm.Parameters.AddWithValue("@admin", usuario.Administrador);
                    comm.Parameters.AddWithValue("@senha", usuario.Senha);
                    comm.Parameters.AddWithValue("@usuario", usuario.Usuario);
                    comm.Parameters.AddWithValue("@segunda", usuario.DiasSemana[1]);
                    comm.Parameters.AddWithValue("@terca", usuario.DiasSemana[2]);
                    comm.Parameters.AddWithValue("@quarta", usuario.DiasSemana[3]);
                    comm.Parameters.AddWithValue("@quinta", usuario.DiasSemana[4]);
                    comm.Parameters.AddWithValue("@sexta", usuario.DiasSemana[5]);
                    comm.Parameters.AddWithValue("@sabado", usuario.DiasSemana[6]);
                    comm.Parameters.AddWithValue("@domingo", usuario.DiasSemana[0]);
                    comm.Parameters.AddWithValue("@tempoMaxUso", usuario.TempoMaxUso);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        public static bool deletUser(string usuario) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("DELETE FROM Usuarios WHERE Usuario = @usuario", conn)) {
                    comm.Parameters.AddWithValue("@usuario", usuario);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    else {
                        return false;
                    }

                }
            }
        }

        public static bool DeletUser(CUsuario usuario) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("DELETE FROM Usuarios WHERE Id = @Id", conn)) {
                    comm.Parameters.AddWithValue("@Id", usuario.Id);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    else {
                        return false;
                    }

                }
            }
        }

        public static CUsuario GetUser(int id) {
            CUsuario ret = null;
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Usuarios WHERE Id = @id", conn)) {
                    comm.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    using (SQLiteDataReader reader = comm.ExecuteReader()) {
                        while (reader.Read()) {
                            ret = new CUsuario {
                                Id = int.Parse(reader["Id"].ToString()),
                                Usuario = reader["Usuario"].ToString(),
                                Senha = reader["Senha"].ToString(),
                                Administrador = bool.Parse(reader["Administrador"].ToString()),
                                DiasSemana = new bool[]{
                                    bool.Parse(reader["Domingo"].ToString()),
                                    bool.Parse(reader["Segunda"].ToString()),
                                    bool.Parse(reader["Terca"].ToString()),
                                    bool.Parse(reader["Quarta"].ToString()),
                                    bool.Parse(reader["Quinta"].ToString()),
                                    bool.Parse(reader["Sexta"].ToString()),
                                    bool.Parse(reader["Sabado"].ToString())
                                },
                                NivelJogo = reader["NivelQuestoes"].ToString(),
                                TempoMaxUso = reader["TempoMaxUso"].ToString(),
                                TempoUsado = int.Parse(reader["TempoUsado"].ToString()),
                                UltimaVezUsado = reader["UltimaVezUsado"].ToString(),

                            };
                        }
                    }
                }
            }

            ret.SitesPermitidos = GetSites(ret.Id);
            ret.Historico = GetHist(ret.Id);
            return ret;
        }

        //SitePermitidos

        public static bool SetSite(int id, string site) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("INSERT INTO Sites(Id,Site) VALUES (@Id,@Site)", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    comm.Parameters.AddWithValue("@Site", site);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        public static string[] getSites(int id) {
            List<string> arrayDi = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT Site FROM Sites WHERE Id = @Id", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    using (SQLiteDataReader reader = comm.ExecuteReader()) {
                        while (reader.Read()) {
                            arrayDi.Add(reader["Site"].ToString());
                        }
                    }
                }
            }
            if (arrayDi.ToArray().Count() == 0) {
                return new string[] { "sem dados" };
            }
            return arrayDi.ToArray();
        }

        public static List<CSitePermitido> GetSites(int id) {
            List<CSitePermitido> arrayDi = new List<CSitePermitido>();
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Sites WHERE Id = @Id", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    using (SQLiteDataReader reader = comm.ExecuteReader()) {
                        while (reader.Read()) {
                            arrayDi.Add(new CSitePermitido() {
                                id_site = int.Parse(reader["id_site"].ToString()),
                                site = reader["site"].ToString(),
                                id_usuario = int.Parse(reader["id"].ToString())
                            });
                        }
                    }
                }
            }
            if (arrayDi.ToArray().Count() == 0) {
                return arrayDi;
            }
            return arrayDi;
        }

        public static bool deletSite(int id, string site) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("DELETE FROM Sites WHERE Id = @Id AND Site = @Site", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    comm.Parameters.AddWithValue("@Site", site);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        public static bool DeletSite(CSitePermitido site) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("DELETE FROM Sites WHERE Id_site = @Id_Site", conn)) {
                    comm.Parameters.AddWithValue("@Id_Site", site.id_site);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        public static bool updateSitePermitido(int id, string site) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("update Historico set Site = @site WHERE Id = @Id", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    comm.Parameters.AddWithValue("@site", site);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        public static bool UpdateSitePermitido(CSitePermitido site) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("update Sites set Site = @site WHERE Id_site = @Id_Site", conn)) {
                    comm.Parameters.AddWithValue("@Id_Site", site.id_site);
                    comm.Parameters.AddWithValue("@site", site.site);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        //Configurações

        public static bool setDia(int id) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("update Usuarios set UltimaVezUsado = datetime('now') WHERE Id = @Id", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        public static bool setConfig(int id, bool[] diasSemana, string nivelQuestoes, string tempoMaxUso) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("UPDATE Usuarios SET Segunda = @Segunda, Terca = @Terca, Quarta = @Quarta, Quinta = @Quinta, Sexta = @Sexta, " +
                        "Sabado = @Sabado, Domingo = @Domingo, NivelQuestoes = @NiveQuestoes, TempoMaxUso = @TempoMaxUso WHERE Id = @Id ", conn)) {

                    comm.Parameters.AddWithValue("@Id", id);
                    comm.Parameters.AddWithValue("@Segunda", diasSemana[1]);
                    comm.Parameters.AddWithValue("@Terca", diasSemana[2]);
                    comm.Parameters.AddWithValue("@Quarta", diasSemana[3]);
                    comm.Parameters.AddWithValue("@Quinta", diasSemana[4]);
                    comm.Parameters.AddWithValue("@Sexta", diasSemana[5]);
                    comm.Parameters.AddWithValue("@Sabado", diasSemana[6]);
                    comm.Parameters.AddWithValue("@Domingo", diasSemana[0]);
                    comm.Parameters.AddWithValue("@NiveQuestoes", nivelQuestoes);
                    comm.Parameters.AddWithValue("@TempoMaxUso", tempoMaxUso);

                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        // MessageBox.Show("Configuração salva com sucesso!!");
                        return true;
                    }
                    return false;
                }
            }
        }

        public static bool setTempUsed(int id) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("update Usuarios set TempoUsado = 0 WHERE Id = @Id", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        public static bool setTempUsed(int id, int temp) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("update Usuarios set TempoUsado = @temp WHERE Id = @Id", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    comm.Parameters.AddWithValue("@temp", temp);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        public static bool getNivelU(int id) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT Administrador FROM Usuarios WHERE id = @id", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    return bool.Parse(Convert.ToString(comm.ExecuteScalar()));
                }
            }
        }

        //Historico

        public static bool SetHist(int id, string site, DateTime data) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("INSERT INTO Historico(Id, Site, Data, Hora) VALUES (@Id, @site, @data, @hora )", conn)) {
                    //INSERT INTO Historico(id, site, data, hora) VALUES(10, 'WW335WWWWW', '2017-08-15', '02:29:34');
                    comm.Parameters.AddWithValue("@Id", id);
                    comm.Parameters.AddWithValue("@site", site);

                    //MessageBox.Show(data.ToString("yyyy-MM-dd"));

                    comm.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd"));
                    comm.Parameters.AddWithValue("@hora", data.ToString("HH:mm:ss"));

                    //MessageBox.Show(data.ToString("HH:mm:ss"));
                    //MessageBox.Show(comm.CommandText);

                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        public static List<CHistorico> GetHist(int id) {
            List<CHistorico> list = new List<CHistorico>();
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Historico WHERE Id = @Id", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    using (SQLiteDataReader reader = comm.ExecuteReader()) {
                        while (reader.Read()) {

                            DateTime dt = DateTime.Parse(reader["data"].ToString());
                            DateTime hr = DateTime.Parse(reader["hora"].ToString());

                            // MessageBox.Show("" + dt.ToString("dd/MM/yyyy") + ":::" + hr.ToString("hh: mm:ss"));

                            list.Add(new CHistorico {
                                Id_Usuario = reader["id"].ToString(),
                                Data = dt.ToString("dd/MM/yyyy"),
                                Hora = hr.ToString("HH:mm:ss"),
                                Site = reader["site"].ToString(),
                                Id_Site = int.Parse(reader["id_site"].ToString())
                            });
                        }
                    }
                }
            }
            return list;
        }

        public static bool delLinhaHisto(int id) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("DELETE FROM Historico WHERE id_site = @Id ", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        public static bool delHisto(int id) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("DELETE FROM Historico WHERE id = @Id", conn)) {
                    comm.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        //Questoes//

        //public static CQuestao GetQuiz(object nivel) {
        //    CQuestao ret = null;
        //    using (SQLiteConnection conn = new SQLiteConnection(path)) {
        //        using (SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Questoes WHERE nivel = @nivel ORDER BY Random() LIMIT 1", conn)) {
        //            comm.Parameters.AddWithValue("@nivel", nivel);
        //            conn.Open();
        //            using (SQLiteDataReader reader = comm.ExecuteReader()) {
        //                while (reader.Read()) {
        //                    ret = new CQuestao(int.Parse(reader["Id"].ToString())) {
        //                        Pergunta = reader["pergunta"].ToString(),
        //                        Nivel = reader["Nivel"].ToString(),
        //                        listaRespostas = new List<CResposta> {
        //                            new CResposta() {
        //                                resposta = reader["resposta"].ToString(),
        //                                certa = true
        //                            },
        //                            new CResposta() {
        //                                resposta = reader["posivel1"].ToString(),
        //                                certa = false
        //                            },
        //                            new CResposta() {
        //                                resposta = reader["posivel2"].ToString(),
        //                                certa = false
        //                            }
        //                        }
        //                    };
        //                }
        //            }
        //        }
        //    }
        //    return ret;
        //}

        public static CQuestao GetPergunta(int id) {

            CQuestao ret = null;
            List<CResposta> respTemp;

            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Questoes WHERE Id_Questao = @Id_Questao", conn)) {
                    comm.Parameters.AddWithValue("@Id_Questao", id);
                    conn.Open();
                    using (SQLiteDataReader reader = comm.ExecuteReader()) {
                        while (reader.Read()) {

                            respTemp = GetRespostas(int.Parse(reader["Id_Questao"].ToString()));

                            ret = new CQuestao() {
                                Id = int.Parse(reader["Id_Questao"].ToString()),
                                Pergunta = reader["pergunta"].ToString(),
                                Nivel = reader["Nivel_Questao"].ToString(),
                                listaRespostas = respTemp
                            };
                        }
                    }
                }
            }
            return ret;
        }

        public static int SetPergunta(CQuestao pergunta) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("INSERT INTO Questoes(Pergunta, Nivel_Questao) VALUES(@Pergunta, @Nivel_Questao)", conn)) {
                    comm.Parameters.AddWithValue("@Pergunta", pergunta.Pergunta);
                    comm.Parameters.AddWithValue("@Nivel_Questao", pergunta.Nivel);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return int.Parse(conn.LastInsertRowId.ToString());
                    }
                    return -1;
                }
            }
        }

        public static bool UpdatePergunta(CQuestao questao) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("UPDATE Questoes SET Pergunta = @Pergunta, Nivel_Questao = @Nivel_Questao WHERE Id_Questao = @Id_Questao", conn)) {
                    comm.Parameters.AddWithValue("@Id_Questao", questao.Id);
                    comm.Parameters.AddWithValue("@Pergunta", questao.Pergunta);
                    comm.Parameters.AddWithValue("@Nivel_Questao", questao.Nivel);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        public static List<CQuestao> GetPerguntas(string nivel) {
            List<CQuestao> ret = new List<CQuestao>();
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Questoes WHERE Nivel_Questao = @nivel ORDER BY Random()", conn)) {
                    comm.Parameters.AddWithValue("@nivel", nivel);
                    conn.Open();
                    using (SQLiteDataReader reader = comm.ExecuteReader()) {
                        while (reader.Read()) {
                            ret.Add(new CQuestao() {
                                Id = int.Parse(reader["Id_Questao"].ToString()),
                                Pergunta = reader["Pergunta"].ToString(),
                                Nivel = reader["Nivel_Questao"].ToString(),
                                listaRespostas = GetRespostas(int.Parse(reader["Id_Questao"].ToString()))
                            });
                        }
                    }
                }
            }
            return ret;
        }

        public static List<CQuestao> GetPerguntas() {
            List<CQuestao> ret = new List<CQuestao>();
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Questoes ORDER BY Random()", conn)) {
                    conn.Open();
                    using (SQLiteDataReader reader = comm.ExecuteReader()) {
                        while (reader.Read()) {
                            ret.Add(new CQuestao() {
                                Id = int.Parse(reader["Id_Questao"].ToString()),
                                Pergunta = reader["Pergunta"].ToString(),
                                Nivel = reader["Nivel_Questao"].ToString(),
                                listaRespostas = GetRespostas(int.Parse(reader["Id_Questao"].ToString()))
                            });
                        }
                    }
                }
            }
            return ret;
        }

        public static List<CResposta> GetRespostas(int id_Questao) {
            List<CResposta> ret = new List<CResposta>();
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Respostas WHERE Id_Questao = @id_Questao ORDER BY Random()", conn)) {
                    comm.Parameters.AddWithValue("@id_Questao", id_Questao);
                    conn.Open();
                    using (SQLiteDataReader reader = comm.ExecuteReader()) {
                        while (reader.Read()) {
                            ret.Add(new CResposta() {
                                id_Resposta = int.Parse(reader["Id_Resposta"].ToString()),
                                id_Questao = int.Parse(reader["Id_Questao"].ToString()),
                                resposta = reader["Resposta"].ToString(),
                                certa = bool.Parse(reader["Resposta_Certa"].ToString())
                            });
                        }
                    }
                }
            }
            return ret;
        }

        public static CResposta GetResposta(int id_Resposta) {

            CResposta ret = null;

            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Respostas WHERE Id_Resposta = @id_Respostas",conn)) {
                    comm.Parameters.AddWithValue("@id_Respostas", id_Resposta);
                    conn.Open();
                    using (SQLiteDataReader reader = comm.ExecuteReader()) {
                        while (reader.Read()) {
                            ret = new CResposta() {
                                id_Resposta = int.Parse(reader["Id_Resposta"].ToString()),
                                id_Questao = int.Parse(reader["Id_Questao"].ToString()),
                                resposta = reader["Resposta"].ToString(),
                                certa = bool.Parse(reader["Resposta_Certa"].ToString())
                            };
                        }
                    }
                }
            }
            return ret;
        }

        public static bool SetResposta(CResposta resposta) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("INSERT INTO Respostas(Id_Questao, Resposta, Resposta_Certa) VALUES(@Id_Questao, @Resposta, @Resposta_Certa)", conn)) {
                    comm.Parameters.AddWithValue("@Id_Questao", resposta.id_Questao);
                    comm.Parameters.AddWithValue("@Resposta", resposta.resposta);
                    comm.Parameters.AddWithValue("@Resposta_Certa", resposta.certa);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        public static bool UpdateResposta(CResposta resposta) {
            using (SQLiteConnection conn = new SQLiteConnection(path)) {
                using (SQLiteCommand comm = new SQLiteCommand("UPDATE Respostas SET Resposta = @Resposta, Resposta_Certa = @Certa WHERE Id_Resposta = @Id_Resposta", conn)) {
                    comm.Parameters.AddWithValue("@Id_Resposta", resposta.id_Resposta);
                    comm.Parameters.AddWithValue("@Resposta", resposta.resposta);
                    comm.Parameters.AddWithValue("@Certa", resposta.certa);
                    conn.Open();
                    if (comm.ExecuteNonQuery() != 0) {
                        return true;
                    }
                    return false;
                }
            }
        }

        // --- ---- ---

        public static int getOnlyNum(string str) {
            Regex re = new Regex("[0-9]");
            StringBuilder s = new StringBuilder();

            foreach (Match m in re.Matches(str)) {
                s.Append(m.Value);
            }

            //MessageBox.Show(s.ToString());
            return int.Parse(s.ToString());
        }

        // stackoverflow.com/a/3294698/162671
        public static DateTime GetNetworkTime() {
            try {
                //Servidor nacional para melhor latência
                const string ntpServer = "a.ntp.br";

                // Tamanho da mensagem NTP - 16 bytes (RFC 2030)
                var ntpData = new byte[48];

                //Indicador de Leap (ver RFC), Versão e Modo
                ntpData[0] = 0x1B; //LI = 0 (sem warnings), VN = 3 (IPv4 apenas), Mode = 3 (modo cliente)

                var addresses = Dns.GetHostEntry(ntpServer).AddressList;

                //123 é a porta padrão do NTP
                var ipEndPoint = new IPEndPoint(addresses[0], 123);
                //NTP usa UDP
                var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                socket.Connect(ipEndPoint);

                //Caso NTP esteja bloqueado, ao menos nao trava o app
                socket.ReceiveTimeout = 3000;

                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();

                //Offset para chegar no campo "Transmit Timestamp" (que é
                //o do momento da saída do servidor, em formato 64-bit timestamp
                const byte serverReplyTime = 40;

                //Pegando os segundos
                ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

                //e a fração de segundos
                ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

                //Passando de big-endian pra little-endian
                intPart = SwapEndianness(intPart);
                fractPart = SwapEndianness(fractPart);

                var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

                //Tempo em **UTC**
                var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

                return networkDateTime.ToLocalTime();

            }
            catch (Exception ex) {
              /*MessageBox.Show("" + ex);*/
                return DateTime.Now;
            }

        }
        static uint SwapEndianness(ulong x) {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }

        //public static List<cHist> GetSites(int id) {
        //    List<cHist> arrayDi = new List<cHist>();
        //    using (SQLiteConnection conn = new SQLiteConnection(path)) {
        //        using (SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Sites WHERE Id = @Id", conn)) {
        //            comm.Parameters.AddWithValue("@Id", id);
        //            conn.Open();
        //            using (SQLiteDataReader reader = comm.ExecuteReader()) {
        //                while (reader.Read()) {
        //                    //arrayDi.Add(reader["Site"].ToString());
        //                    arrayDi.Add(new cHist {
        //                        Id = reader["Id"].ToString(),
        //                        Site = reader["Site"].ToString(),
        //                        Data = reader["Data"].ToString(),
        //                        Hora = reader["Hora"].ToString(),
        //                        Id_Site = int.Parse(reader["id_site"].ToString())
        //                    });
        //                }
        //            }
        //        }
        //    }
        //    if (arrayDi.ToArray().Count() == 0) {
        //        return new List<cHist>{ };
        //    }
        //    return arrayDi;
        //}

        //public static cHist[] GetHist(int id) {
        //    List<cHist> list = new List<cHist>();
        //    using (SQLiteConnection conn = new SQLiteConnection(path)) {
        //        using (SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Historico WHERE Id = @Id", conn)) {
        //            comm.Parameters.AddWithValue("@Id", id);
        //            conn.Open();
        //            using (SQLiteDataReader reader = comm.ExecuteReader()) {
        //                while (reader.Read()) {

        //                    DateTime dt = DateTime.Parse(reader["data"].ToString());
        //                    DateTime hr = DateTime.Parse(reader["hora"].ToString());

        //                    // MessageBox.Show("" + dt.ToString("dd/MM/yyyy") + ":::" + hr.ToString("hh: mm:ss"));

        //                    list.Add(new cHist {
        //                        Id = reader["id"].ToString(),
        //                        Data = dt.ToString("dd/MM/yyyy"),
        //                        Hora = hr.ToString("HH:mm:ss"),
        //                        Site = reader["site"].ToString()
        //                    });
        //                }
        //            }
        //        }
        //    }
        //    return list.ToArray();
        //}

    }
}
