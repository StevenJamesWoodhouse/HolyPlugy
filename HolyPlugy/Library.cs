﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HolyPlugy
{
    class Library
    {
        private List<StashCollection> stashCollections;
        private List<PlayerCharacter> playerCharacters;
        public List<StashCollection> getStashes()
        {
            return stashCollections;
        }
        public void setStashes(List<StashCollection> stashCollections)
        {
            this.stashCollections = stashCollections;
        }
        public List<PlayerCharacter> getPlayerCharacters()
        {
            return playerCharacters;
        }
        public void setPlayerCharacters(List<PlayerCharacter> playerCharacters)
        {
            this.playerCharacters = playerCharacters;
        }
	}
}
