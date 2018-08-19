﻿/*
 * This file is part of alphaTab.
 * Copyright © 2018, Daniel Kuschny and Contributors, All rights reserved.
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3.0 of the License, or at your option any later version.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library.
 */

using Haxe;
using Phase.Attributes;

namespace AlphaTab.Haxe.Js.Html
{
    [External]
    [Name("js.html.HTMLDocument")]
    public class HTMLDocument : Document
    {
        [Name("write")]
        public extern void Write(HaxeString s);
        [Name("body")]
        public extern BodyElement Body { get; set; }
        [Name("documentElement")]
        public extern Element DocumentElement { get; set; }
        [Name("createTextNode")]
        public extern Node CreateTextNode(HaxeString text);
    }
}