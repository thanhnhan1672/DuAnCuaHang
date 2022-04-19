using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DuAnCuaHang.Models
{
    public class DatBanGenreViewModel
    {
        public List<DatBan>? DatBans { get; set; }
        public SelectList? Genres { get; set; }
        public string? DatBanGenre { get; set; }
        public string? SearchString { get; set; }

    }
}