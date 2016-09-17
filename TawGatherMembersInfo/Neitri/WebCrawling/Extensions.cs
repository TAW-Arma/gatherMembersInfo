﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Neitri.WebCrawling
{
	public static class Extensions
	{
		public static HtmlDocument GetHtml(this HttpWebResponse response)
		{
			return response.GetResponseStream().ReadTextToEnd().ToHtmlDocument();
		}
		public static HtmlDocument ToHtmlDocument(this string htmlText)
		{
			var html = new HtmlDocument();
			html.LoadHtml(htmlText);
			return html;
		}

	}
}