using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.Gcrm.Medvedev.SingletonConsoleApp
{
    /// <summary>
    /// Пользовательское подключение.
    /// </summary>
    public class UserConnection
    {
        #region Свойства.
        /// <summary>
        /// Права администратора.
        /// </summary>
        public bool AdminRight { get; set; }

        /// <summary>
        /// Права на доступ к базе данных.
        /// </summary>
        public bool DataBaseRigth { get; set; }

        private static UserConnection _userConnection;

        #endregion

        private UserConnection(bool adminRight, bool dataBaseRigth)
        {
            AdminRight = adminRight;
            DataBaseRigth = dataBaseRigth;
        }

        /// <summary>
        /// Получение пользовательского подключения.
        /// </summary>
        /// <param name="adminRight"> Права администратора.</param>
        /// <param name="dataBaseRigth"> Права доступа к базе данных.</param>
        /// <returns></returns>
        public static UserConnection GetUserConnection(bool adminRight, bool dataBaseRigth)
        {
            if (_userConnection == null)
            {
                _userConnection = new UserConnection(adminRight, dataBaseRigth);
            }
            else
            {
                _userConnection.AdminRight = adminRight;
                _userConnection.DataBaseRigth = dataBaseRigth;
            }

            return _userConnection;
        }
    }
}
