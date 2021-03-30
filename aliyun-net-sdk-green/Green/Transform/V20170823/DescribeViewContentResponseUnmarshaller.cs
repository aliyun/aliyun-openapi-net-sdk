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
			describeViewContentResponse.RequestId = _ctx.StringValue("DescribeViewContent.RequestId");
			describeViewContentResponse.PageSize = _ctx.IntegerValue("DescribeViewContent.PageSize");
			describeViewContentResponse.CurrentPage = _ctx.IntegerValue("DescribeViewContent.CurrentPage");
			describeViewContentResponse.TotalCount = _ctx.IntegerValue("DescribeViewContent.TotalCount");

			List<DescribeViewContentResponse.DescribeViewContent_ViewContent> describeViewContentResponse_viewContentList = new List<DescribeViewContentResponse.DescribeViewContent_ViewContent>();
			for (int i = 0; i < _ctx.Length("DescribeViewContent.ViewContentList.Length"); i++) {
				DescribeViewContentResponse.DescribeViewContent_ViewContent viewContent = new DescribeViewContentResponse.DescribeViewContent_ViewContent();
				viewContent.TaskId = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].TaskId");
				viewContent.DataId = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].DataId");
				viewContent.BizType = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].BizType");
				viewContent.Content = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Content");
				viewContent.Url = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Url");
				viewContent.NewUrl = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].NewUrl");
				viewContent.Thumbnail = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Thumbnail");
				viewContent.RequestTime = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].RequestTime");
				viewContent.ScanFinishedTime = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].ScanFinishedTime");
				viewContent.Suggestion = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Suggestion");
				viewContent.Id = _ctx.LongValue("DescribeViewContent.ViewContentList["+ i +"].Id");
				viewContent.ScanResult = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].ScanResult");

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
					frameResult.Url = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FrameResults["+ j +"].Url");
					frameResult.Offset = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FrameResults["+ j +"].Offset");
					frameResult.Label = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FrameResults["+ j +"].Label");

					viewContent_frameResults.Add(frameResult);
				}
				viewContent.FrameResults = viewContent_frameResults;

				List<DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult> viewContent_faceResults = new List<DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult>();
				for (int j = 0; j < _ctx.Length("DescribeViewContent.ViewContentList["+ i +"].FaceResults.Length"); j++) {
					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult faceResult = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult();
					faceResult.Bualified = _ctx.BooleanValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Bualified");

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Location location = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Location();
					location.X = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Location.X");
					location.Y = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Location.Y");
					location.W = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Location.W");
					location.H = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Location.H");
					faceResult.Location = location;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Gender gender = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Gender();
					gender.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Gender.Rate");
					gender._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Gender.Value");
					faceResult.Gender = gender;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Glasses glasses = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Glasses();
					glasses.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Glasses.Rate");
					glasses._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Glasses.Value");
					faceResult.Glasses = glasses;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Age age = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Age();
					age.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Age.Rate");
					age._Value = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Age.Value");
					faceResult.Age = age;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Smile smile = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Smile();
					smile.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Smile.Rate");
					smile._Value = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Smile.Value");
					faceResult.Smile = smile;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Quality quality = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Quality();
					quality.Blur = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Quality.Blur");
					quality.Pitch = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Quality.Pitch");
					quality.Yaw = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Quality.Yaw");
					quality.Roll = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Quality.Roll");
					faceResult.Quality = quality;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Respirator respirator = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Respirator();
					respirator.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Respirator.Rate");
					respirator._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Respirator.Value");
					faceResult.Respirator = respirator;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Hat hat = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Hat();
					hat.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Hat.Rate");
					hat._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Hat.Value");
					faceResult.Hat = hat;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Mustache mustache = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Mustache();
					mustache.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Mustache.Rate");
					mustache._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Mustache.Value");
					faceResult.Mustache = mustache;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Bang bang = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Bang();
					bang.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Bang.Rate");
					bang._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Bang.Value");
					faceResult.Bang = bang;

					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Hairstyle hairstyle = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FaceResult.DescribeViewContent_Hairstyle();
					hairstyle.Rate = _ctx.FloatValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Hairstyle.Rate");
					hairstyle._Value = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FaceResults["+ j +"].Hairstyle.Value");
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
