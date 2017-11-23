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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudPhoto.Model.V20170711;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class ListTimeLinesResponseUnmarshaller
    {
        public static ListTimeLinesResponse Unmarshall(UnmarshallerContext context)
        {
			ListTimeLinesResponse listTimeLinesResponse = new ListTimeLinesResponse();

			listTimeLinesResponse.HttpResponse = context.HttpResponse;
			listTimeLinesResponse.Code = context.StringValue("ListTimeLines.Code");
			listTimeLinesResponse.Message = context.StringValue("ListTimeLines.Message");
			listTimeLinesResponse.NextCursor = context.IntegerValue("ListTimeLines.NextCursor");
			listTimeLinesResponse.RequestId = context.StringValue("ListTimeLines.RequestId");
			listTimeLinesResponse.Action = context.StringValue("ListTimeLines.Action");

			List<ListTimeLinesResponse.ListTimeLines_TimeLine> listTimeLinesResponse_timeLines = new List<ListTimeLinesResponse.ListTimeLines_TimeLine>();
			for (int i = 0; i < context.Length("ListTimeLines.TimeLines.Length"); i++) {
				ListTimeLinesResponse.ListTimeLines_TimeLine timeLine = new ListTimeLinesResponse.ListTimeLines_TimeLine();
				timeLine.StartTime = context.LongValue("ListTimeLines.TimeLines["+ i +"].StartTime");
				timeLine.EndTime = context.LongValue("ListTimeLines.TimeLines["+ i +"].EndTime");
				timeLine.TotalCount = context.IntegerValue("ListTimeLines.TimeLines["+ i +"].TotalCount");
				timeLine.PhotosCount = context.IntegerValue("ListTimeLines.TimeLines["+ i +"].PhotosCount");

				List<ListTimeLinesResponse.ListTimeLines_TimeLine.ListTimeLines_Photo> timeLine_photos = new List<ListTimeLinesResponse.ListTimeLines_TimeLine.ListTimeLines_Photo>();
				for (int j = 0; j < context.Length("ListTimeLines.TimeLines["+ i +"].Photos.Length"); j++) {
					ListTimeLinesResponse.ListTimeLines_TimeLine.ListTimeLines_Photo photo = new ListTimeLinesResponse.ListTimeLines_TimeLine.ListTimeLines_Photo();
					photo.Id = context.LongValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].Id");
					photo.Title = context.StringValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].Title");
					photo.FileId = context.StringValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].FileId");
					photo.State = context.StringValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].State");
					photo.Md5 = context.StringValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].Md5");
					photo.IsVideo = context.BooleanValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].IsVideo");
					photo.Remark = context.StringValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].Remark");
					photo.Width = context.LongValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].Width");
					photo.Height = context.LongValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].Height");
					photo.Ctime = context.LongValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].Ctime");
					photo.Mtime = context.LongValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].Mtime");
					photo.TakenAt = context.LongValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].TakenAt");
					photo.ShareExpireTime = context.LongValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].ShareExpireTime");
					photo.Like = context.LongValue("ListTimeLines.TimeLines["+ i +"].Photos["+ j +"].Like");

					timeLine_photos.Add(photo);
				}
				timeLine.Photos = timeLine_photos;

				listTimeLinesResponse_timeLines.Add(timeLine);
			}
			listTimeLinesResponse.TimeLines = listTimeLinesResponse_timeLines;
        
			return listTimeLinesResponse;
        }
    }
}