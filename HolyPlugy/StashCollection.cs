using System;
using System.Collections.Generic;
using System.Text;

namespace HolyPlugy
{
    class StashCollection
    {
        private List<Stash> stashes;
        private String fileName;
        public List<Stash> getStashes()
        {
            return stashes;
        }
        public void setStashes(List<Stash> stashes)
        {
            this.stashes = stashes;
        }
        public String getFileName()
        {
            return fileName;
        }
        public void setFileName(String fileName)
        {
            this.fileName = fileName;
        }
	}
}
