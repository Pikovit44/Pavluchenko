using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRed
{
    public interface IMessageServise
    {
        void ShowMessage(string message);
        void ShowExclamination(string exclumination);
        void ShowError(string error);
    }

    class MessageService : IMessageServise
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowExclamination(string exclumination)
        {
            MessageBox.Show(exclumination, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
