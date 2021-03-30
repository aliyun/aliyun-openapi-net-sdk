/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeBizTypeTextLibResponseUnmarshaller
    {
        public static DescribeBizTypeTextLibResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBizTypeTextLibResponse describeBizTypeTextLibResponse = new DescribeBizTypeTextLibResponse();

			describeBizTypeTextLibResponse.HttpResponse = _ctx.HttpResponse;
			describeBizTypeTextLibResponse.RequestId = _ctx.StringValue("DescribeBizTypeTextLib.RequestId");

			DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Black black = new DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Black();

			List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Black.DescribeBizTypeTextLib_WhiteSelectedItem> black_selected = new List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Black.DescribeBizTypeTextLib_WhiteSelectedItem>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeTextLib.Black.Selected.Length"); i++) {
				DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Black.DescribeBizTypeTextLib_WhiteSelectedItem whiteSelectedItem = new DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Black.DescribeBizTypeTextLib_WhiteSelectedItem();
				whiteSelectedItem.Name = _ctx.StringValue("DescribeBizTypeTextLib.Black.Selected["+ i +"].Name");
				whiteSelectedItem.Code = _ctx.StringValue("DescribeBizTypeTextLib.Black.Selected["+ i +"].Code");

				black_selected.Add(whiteSelectedItem);
			}
			black.Selected = black_selected;

			List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Black.DescribeBizTypeTextLib_WhiteAllItem> black_all = new List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Black.DescribeBizTypeTextLib_WhiteAllItem>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeTextLib.Black.All.Length"); i++) {
				DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Black.DescribeBizTypeTextLib_WhiteAllItem whiteAllItem = new DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Black.DescribeBizTypeTextLib_WhiteAllItem();
				whiteAllItem.Name = _ctx.StringValue("DescribeBizTypeTextLib.Black.All["+ i +"].Name");
				whiteAllItem.Code = _ctx.StringValue("DescribeBizTypeTextLib.Black.All["+ i +"].Code");

				black_all.Add(whiteAllItem);
			}
			black.All = black_all;
			describeBizTypeTextLibResponse.Black = black;

			DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Review review = new DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Review();

			List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Review.DescribeBizTypeTextLib_WhiteSelectedItem3> review_selected1 = new List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Review.DescribeBizTypeTextLib_WhiteSelectedItem3>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeTextLib.Review.Selected.Length"); i++) {
				DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Review.DescribeBizTypeTextLib_WhiteSelectedItem3 whiteSelectedItem3 = new DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Review.DescribeBizTypeTextLib_WhiteSelectedItem3();
				whiteSelectedItem3.Name = _ctx.StringValue("DescribeBizTypeTextLib.Review.Selected["+ i +"].Name");
				whiteSelectedItem3.Code = _ctx.StringValue("DescribeBizTypeTextLib.Review.Selected["+ i +"].Code");

				review_selected1.Add(whiteSelectedItem3);
			}
			review.Selected1 = review_selected1;

			List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Review.DescribeBizTypeTextLib_WhiteAllItem4> review_all2 = new List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Review.DescribeBizTypeTextLib_WhiteAllItem4>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeTextLib.Review.All.Length"); i++) {
				DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Review.DescribeBizTypeTextLib_WhiteAllItem4 whiteAllItem4 = new DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Review.DescribeBizTypeTextLib_WhiteAllItem4();
				whiteAllItem4.Name = _ctx.StringValue("DescribeBizTypeTextLib.Review.All["+ i +"].Name");
				whiteAllItem4.Code = _ctx.StringValue("DescribeBizTypeTextLib.Review.All["+ i +"].Code");

				review_all2.Add(whiteAllItem4);
			}
			review.All2 = review_all2;
			describeBizTypeTextLibResponse.Review = review;

			DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Ignore ignore = new DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Ignore();

			List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Ignore.DescribeBizTypeTextLib_WhiteSelectedItem7> ignore_selected5 = new List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Ignore.DescribeBizTypeTextLib_WhiteSelectedItem7>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeTextLib.Ignore.Selected.Length"); i++) {
				DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Ignore.DescribeBizTypeTextLib_WhiteSelectedItem7 whiteSelectedItem7 = new DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Ignore.DescribeBizTypeTextLib_WhiteSelectedItem7();
				whiteSelectedItem7.Name = _ctx.StringValue("DescribeBizTypeTextLib.Ignore.Selected["+ i +"].Name");
				whiteSelectedItem7.Code = _ctx.StringValue("DescribeBizTypeTextLib.Ignore.Selected["+ i +"].Code");

				ignore_selected5.Add(whiteSelectedItem7);
			}
			ignore.Selected5 = ignore_selected5;

			List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Ignore.DescribeBizTypeTextLib_WhiteAllItem8> ignore_all6 = new List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Ignore.DescribeBizTypeTextLib_WhiteAllItem8>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeTextLib.Ignore.All.Length"); i++) {
				DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Ignore.DescribeBizTypeTextLib_WhiteAllItem8 whiteAllItem8 = new DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_Ignore.DescribeBizTypeTextLib_WhiteAllItem8();
				whiteAllItem8.Name = _ctx.StringValue("DescribeBizTypeTextLib.Ignore.All["+ i +"].Name");
				whiteAllItem8.Code = _ctx.StringValue("DescribeBizTypeTextLib.Ignore.All["+ i +"].Code");

				ignore_all6.Add(whiteAllItem8);
			}
			ignore.All6 = ignore_all6;
			describeBizTypeTextLibResponse.Ignore = ignore;

			DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_White white = new DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_White();

			List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_White.DescribeBizTypeTextLib_WhiteSelectedItem11> white_selected9 = new List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_White.DescribeBizTypeTextLib_WhiteSelectedItem11>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeTextLib.White.Selected.Length"); i++) {
				DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_White.DescribeBizTypeTextLib_WhiteSelectedItem11 whiteSelectedItem11 = new DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_White.DescribeBizTypeTextLib_WhiteSelectedItem11();
				whiteSelectedItem11.Name = _ctx.StringValue("DescribeBizTypeTextLib.White.Selected["+ i +"].Name");
				whiteSelectedItem11.Code = _ctx.StringValue("DescribeBizTypeTextLib.White.Selected["+ i +"].Code");

				white_selected9.Add(whiteSelectedItem11);
			}
			white.Selected9 = white_selected9;

			List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_White.DescribeBizTypeTextLib_WhiteAllItem12> white_all10 = new List<DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_White.DescribeBizTypeTextLib_WhiteAllItem12>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeTextLib.White.All.Length"); i++) {
				DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_White.DescribeBizTypeTextLib_WhiteAllItem12 whiteAllItem12 = new DescribeBizTypeTextLibResponse.DescribeBizTypeTextLib_White.DescribeBizTypeTextLib_WhiteAllItem12();
				whiteAllItem12.Name = _ctx.StringValue("DescribeBizTypeTextLib.White.All["+ i +"].Name");
				whiteAllItem12.Code = _ctx.StringValue("DescribeBizTypeTextLib.White.All["+ i +"].Code");

				white_all10.Add(whiteAllItem12);
			}
			white.All10 = white_all10;
			describeBizTypeTextLibResponse.White = white;
        
			return describeBizTypeTextLibResponse;
        }
    }
}
