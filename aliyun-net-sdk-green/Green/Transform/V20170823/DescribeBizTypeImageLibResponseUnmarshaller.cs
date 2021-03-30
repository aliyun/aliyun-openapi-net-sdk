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
    public class DescribeBizTypeImageLibResponseUnmarshaller
    {
        public static DescribeBizTypeImageLibResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBizTypeImageLibResponse describeBizTypeImageLibResponse = new DescribeBizTypeImageLibResponse();

			describeBizTypeImageLibResponse.HttpResponse = _ctx.HttpResponse;
			describeBizTypeImageLibResponse.RequestId = _ctx.StringValue("DescribeBizTypeImageLib.RequestId");

			DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Black black = new DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Black();

			List<DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Black.DescribeBizTypeImageLib_WhiteSelectedItem> black_selected = new List<DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Black.DescribeBizTypeImageLib_WhiteSelectedItem>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeImageLib.Black.Selected.Length"); i++) {
				DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Black.DescribeBizTypeImageLib_WhiteSelectedItem whiteSelectedItem = new DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Black.DescribeBizTypeImageLib_WhiteSelectedItem();
				whiteSelectedItem.Name = _ctx.StringValue("DescribeBizTypeImageLib.Black.Selected["+ i +"].Name");
				whiteSelectedItem.Code = _ctx.StringValue("DescribeBizTypeImageLib.Black.Selected["+ i +"].Code");

				black_selected.Add(whiteSelectedItem);
			}
			black.Selected = black_selected;

			List<DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Black.DescribeBizTypeImageLib_WhiteAllItem> black_all = new List<DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Black.DescribeBizTypeImageLib_WhiteAllItem>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeImageLib.Black.All.Length"); i++) {
				DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Black.DescribeBizTypeImageLib_WhiteAllItem whiteAllItem = new DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Black.DescribeBizTypeImageLib_WhiteAllItem();
				whiteAllItem.Name = _ctx.StringValue("DescribeBizTypeImageLib.Black.All["+ i +"].Name");
				whiteAllItem.Code = _ctx.StringValue("DescribeBizTypeImageLib.Black.All["+ i +"].Code");

				black_all.Add(whiteAllItem);
			}
			black.All = black_all;
			describeBizTypeImageLibResponse.Black = black;

			DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Review review = new DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Review();

			List<DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Review.DescribeBizTypeImageLib_WhiteSelectedItem3> review_selected1 = new List<DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Review.DescribeBizTypeImageLib_WhiteSelectedItem3>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeImageLib.Review.Selected.Length"); i++) {
				DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Review.DescribeBizTypeImageLib_WhiteSelectedItem3 whiteSelectedItem3 = new DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Review.DescribeBizTypeImageLib_WhiteSelectedItem3();
				whiteSelectedItem3.Name = _ctx.StringValue("DescribeBizTypeImageLib.Review.Selected["+ i +"].Name");
				whiteSelectedItem3.Code = _ctx.StringValue("DescribeBizTypeImageLib.Review.Selected["+ i +"].Code");

				review_selected1.Add(whiteSelectedItem3);
			}
			review.Selected1 = review_selected1;

			List<DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Review.DescribeBizTypeImageLib_WhiteAllItem4> review_all2 = new List<DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Review.DescribeBizTypeImageLib_WhiteAllItem4>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeImageLib.Review.All.Length"); i++) {
				DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Review.DescribeBizTypeImageLib_WhiteAllItem4 whiteAllItem4 = new DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_Review.DescribeBizTypeImageLib_WhiteAllItem4();
				whiteAllItem4.Name = _ctx.StringValue("DescribeBizTypeImageLib.Review.All["+ i +"].Name");
				whiteAllItem4.Code = _ctx.StringValue("DescribeBizTypeImageLib.Review.All["+ i +"].Code");

				review_all2.Add(whiteAllItem4);
			}
			review.All2 = review_all2;
			describeBizTypeImageLibResponse.Review = review;

			DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_White white = new DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_White();

			List<DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_White.DescribeBizTypeImageLib_WhiteSelectedItem7> white_selected5 = new List<DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_White.DescribeBizTypeImageLib_WhiteSelectedItem7>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeImageLib.White.Selected.Length"); i++) {
				DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_White.DescribeBizTypeImageLib_WhiteSelectedItem7 whiteSelectedItem7 = new DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_White.DescribeBizTypeImageLib_WhiteSelectedItem7();
				whiteSelectedItem7.Name = _ctx.StringValue("DescribeBizTypeImageLib.White.Selected["+ i +"].Name");
				whiteSelectedItem7.Code = _ctx.StringValue("DescribeBizTypeImageLib.White.Selected["+ i +"].Code");

				white_selected5.Add(whiteSelectedItem7);
			}
			white.Selected5 = white_selected5;

			List<DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_White.DescribeBizTypeImageLib_WhiteAllItem8> white_all6 = new List<DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_White.DescribeBizTypeImageLib_WhiteAllItem8>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeImageLib.White.All.Length"); i++) {
				DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_White.DescribeBizTypeImageLib_WhiteAllItem8 whiteAllItem8 = new DescribeBizTypeImageLibResponse.DescribeBizTypeImageLib_White.DescribeBizTypeImageLib_WhiteAllItem8();
				whiteAllItem8.Name = _ctx.StringValue("DescribeBizTypeImageLib.White.All["+ i +"].Name");
				whiteAllItem8.Code = _ctx.StringValue("DescribeBizTypeImageLib.White.All["+ i +"].Code");

				white_all6.Add(whiteAllItem8);
			}
			white.All6 = white_all6;
			describeBizTypeImageLibResponse.White = white;
        
			return describeBizTypeImageLibResponse;
        }
    }
}
