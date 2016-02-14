using System;
using System.Collections.Generic;
using System.Linq;
using TextEditor.BL;
using System.Text;
using System.Threading.Tasks;

namespace TextRed
{
    class MainPresenter
    {
        private readonly IMainForm view;
        private readonly IFileManager manager;
        private readonly IMessageServise messageService;
        private string cuttentFilePath;

        public MainPresenter(IMainForm view, IFileManager manager, IMessageServise servise)
        {
            this.view = view;
            this.manager = manager;
            this.messageService = servise;

            this.view.SetSymbolCount(0);
            this.view.ContentChanged += new EventHandler(view_ContentChanged);
            this.view.FileOpenClick += new EventHandler (View_FileOpenClick);
            this.view.FileSaveClick += new EventHandler (View_FileSaveClick);
            
        }

        private void View_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                string content = this.view.Content;
                this.manager.SaveContent(content, cuttentFilePath);
                this.messageService.ShowMessage("Файл успешно сохранен.");
            }
            catch (Exception ex)
            {
                this.messageService.ShowError(ex.Message);
            };
        }

        private void View_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = this.view.FilePath;
                bool isExist = this.manager.IsExist(filePath);
                if (!isExist)
                {
                    this.messageService.ShowExclamination("Выбранный файл не существует.");
                    return;
                }

                cuttentFilePath = filePath;

                string content = this.manager.GetContent(filePath);
                int count = this.manager.GetSymbolCount(content);

                this.view.Content = content;
                this.view.SetSymbolCount(count);

            }
            catch (Exception ex)
            {
                this.messageService.ShowError(ex.Message);
            }
        }

        void view_ContentChanged(object sender, EventArgs e)
        {
            string content = this.view.Content;
            int count = this.manager.GetSymbolCount(content);
            this.view.SetSymbolCount(count);
        }
    }
}
