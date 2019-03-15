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
using Aliyun.Acs.CloudPhoto.Model.V20170711;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class EditEventResponseUnmarshaller
    {
        public static EditEventResponse Unmarshall(UnmarshallerContext context)
        {
			EditEventResponse editEventResponse = new EditEventResponse();

			editEventResponse.HttpResponse = context.HttpResponse;
			editEventResponse.Code = context.StringValue("EditEvent.Code");
			editEventResponse.Message = context.StringValue("EditEvent.Message");
			editEventResponse.RequestId = context.StringValue("EditEvent.RequestId");
			editEventResponse.Action = context.StringValue("EditEvent.Action");

			EditEventResponse.EditEvent__Event _event = new EditEventResponse.EditEvent__Event();
			_event.Id = context.LongValue("EditEvent.Event.Id");
			_event.IdStr = context.StringValue("EditEvent.Event.IdStr");
			_event.Title = context.StringValue("EditEvent.Event.Title");
			_event.BannerPhotoId = context.StringValue("EditEvent.Event.BannerPhotoId");
			_event.Identity = context.StringValue("EditEvent.Event.Identity");
			_event.SplashPhotoId = context.StringValue("EditEvent.Event.SplashPhotoId");
			_event.State = context.StringValue("EditEvent.Event.State");
			_event.WeixinTitle = context.StringValue("EditEvent.Event.WeixinTitle");
			_event.WatermarkPhotoId = context.StringValue("EditEvent.Event.WatermarkPhotoId");
			_event.StartAt = context.LongValue("EditEvent.Event.StartAt");
			_event.EndAt = context.LongValue("EditEvent.Event.EndAt");
			_event.Ctime = context.LongValue("EditEvent.Event.Ctime");
			_event.Mtime = context.LongValue("EditEvent.Event.Mtime");
			_event.ViewsCount = context.LongValue("EditEvent.Event.ViewsCount");
			_event.LibraryId = context.StringValue("EditEvent.Event.LibraryId");
			_event.IdStr1 = context.StringValue("EditEvent.Event.IdStr");
			editEventResponse._Event = _event;
        
			return editEventResponse;
        }
    }
}
