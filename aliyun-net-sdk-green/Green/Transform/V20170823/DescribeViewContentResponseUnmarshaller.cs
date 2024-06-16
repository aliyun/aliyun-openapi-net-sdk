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
    public class DescribeViewContentResponseUnmarshaller
    {
        public static DescribeViewContentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeViewContentResponse describeViewContentResponse = new DescribeViewContentResponse();

			describeViewContentResponse.HttpResponse = _ctx.HttpResponse;
			describeViewContentResponse.CurrentPage = _ctx.IntegerValue("DescribeViewContent.CurrentPage");
			describeViewContentResponse.RequestId = _ctx.StringValue("DescribeViewContent.RequestId");
			describeViewContentResponse.PageSize = _ctx.IntegerValue("DescribeViewContent.PageSize");
			describeViewContentResponse.TotalCount = _ctx.IntegerValue("DescribeViewContent.TotalCount");

			List<DescribeViewContentResponse.DescribeViewContent_ViewContent> describeViewContentResponse_viewContentList = new List<DescribeViewContentResponse.DescribeViewContent_ViewContent>();
			for (int i = 0; i < _ctx.Length("DescribeViewContent.ViewContentList.Length"); i++) {
				DescribeViewContentResponse.DescribeViewContent_ViewContent viewContent = new DescribeViewContentResponse.DescribeViewContent_ViewContent();
				viewContent.Suggestion = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Suggestion");
				viewContent.ScanResult = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].ScanResult");
				viewContent.Url = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Url");
				viewContent.DataId = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].DataId");
				viewContent.BizType = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].BizType");
				viewContent.NewUrl = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].NewUrl");
				viewContent.ScanFinishedTime = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].ScanFinishedTime");
				viewContent.TaskId = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].TaskId");
				viewContent.Content = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Content");
				viewContent.Thumbnail = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Thumbnail");
				viewContent.Id = _ctx.LongValue("DescribeViewContent.ViewContentList["+ i +"].Id");
				viewContent.RequestTime = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].RequestTime");

				List<DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_Result> viewContent_results = new List<DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_Result>();
				for (int j = 0; j < _ctx.Length("DescribeViewContent.ViewContentList["+ i +"].Results.Length"); j++) {
					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_Result result = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_Result();
					result.Suggestion = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Results["+ j +"].Suggestion");
					result.Label = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Results["+ j +"].Label");
					result.Scene = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Results["+ j +"].Scene");

					viewContent_results.Add(result);
				}
				viewContent.Results = viewContent_results;

				List<DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FrameResult> viewContent_frameResults = new List<DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FrameResult>();
				for (int j = 0; j < _ctx.Length("DescribeViewContent.ViewContentList["+ i +"].FrameResults.Length"); j++) {
					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FrameResult frameResult = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FrameResult();
					frameResult.Offset = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FrameResults["+ j +"].Offset");
					frameResult.Url = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FrameResults["+ j +"].Url");
					frameResult.Label = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FrameResults["+ j +"].Label");

					viewContent_frameResults.Add(frameResult);
				}
				viewContent.FrameResults = viewContent_frameResults;

				List<DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult> viewContent_faceResults = new List<DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult>();
				for (int j = 0; j < _ctx.Length("DescribeViewContent.ViewContentList["+ i +"].FaceResults.Length"); j++) {
					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult faceResult = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult();
					faceResult.Bualified = _ctx.BooleanValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Bualified");

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Location location = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Location();
					location.Y = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Location.Y");
					location.W = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Location.W");
					location.H = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Location.H");
					location.X = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Location.X");
					faceResult.Location = location;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Gender gender = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Gender();
					gender._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Gender.Value");
					gender.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Gender.Rate");
					faceResult.Gender = gender;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Glasses glasses = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Glasses();
					glasses._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Glasses.Value");
					glasses.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Glasses.Rate");
					faceResult.Glasses = glasses;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Age age = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Age();
					age._Value = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Age.Value");
					age.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Age.Rate");
					faceResult.Age = age;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Smile smile = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Smile();
					smile._Value = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Smile.Value");
					smile.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Smile.Rate");
					faceResult.Smile = smile;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Quality quality = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Quality();
					quality.Roll = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Quality.Roll");
					quality.Pitch = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Quality.Pitch");
					quality.Yaw = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Quality.Yaw");
					quality.Blur = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Quality.Blur");
					faceResult.Quality = quality;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Respirator respirator = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Respirator();
					respirator._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Respirator.Value");
					respirator.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Respirator.Rate");
					faceResult.Respirator = respirator;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Hat hat = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Hat();
					hat._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Hat.Value");
					hat.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Hat.Rate");
					faceResult.Hat = hat;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Mustache mustache = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Mustache();
					mustache._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Mustache.Value");
					mustache.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Mustache.Rate");
					faceResult.Mustache = mustache;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Bang bang = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Bang();
					bang._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Bang.Value");
					bang.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Bang.Rate");
					faceResult.Bang = bang;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Hairstyle hairstyle = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Hairstyle();
					hairstyle._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Hairstyle.Value");
					hairstyle.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Hairstyle.Rate");
					faceResult.Hairstyle = hairstyle;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Image image = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Image();
					image.Width = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Image.Width");
					image.Height = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Image.Height");
					faceResult.Image = image;

					viewContent_faceResults.Add(faceResult);
				}
				viewContent.FaceResults = viewContent_faceResults;

				describeViewContentResponse_viewContentList.Add(viewContent);
			}
			describeViewContentResponse.ViewContentList = describeViewContentResponse_viewContentList;
        
			return describeViewContentResponse;
        }
    }
}
