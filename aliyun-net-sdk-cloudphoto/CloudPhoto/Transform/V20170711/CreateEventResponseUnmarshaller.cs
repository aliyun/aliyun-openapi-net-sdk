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
    public class CreateEventResponseUnmarshaller
    {
        public static CreateEventResponse Unmarshall(UnmarshallerContext context)
        {
			CreateEventResponse createEventResponse = new CreateEventResponse();

			createEventResponse.HttpResponse = context.HttpResponse;
			createEventResponse.Code = context.StringValue("CreateEvent.Code");
			createEventResponse.Message = context.StringValue("CreateEvent.Message");
			createEventResponse.RequestId = context.StringValue("CreateEvent.RequestId");
			createEventResponse.Action = context.StringValue("CreateEvent.Action");

			CreateEventResponse.CreateEvent__Event _event = new CreateEventResponse.CreateEvent__Event();
			_event.Id = context.LongValue("CreateEvent.Event.Id");
			_event.IdStr = context.StringValue("CreateEvent.Event.IdStr");
			_event.Title = context.StringValue("CreateEvent.Event.Title");
			_event.BannerPhotoId = context.StringValue("CreateEvent.Event.BannerPhotoId");
			_event.Identity = context.StringValue("CreateEvent.Event.Identity");
			_event.SplashPhotoId = context.StringValue("CreateEvent.Event.SplashPhotoId");
			_event.State = context.StringValue("CreateEvent.Event.State");
			_event.WeixinTitle = context.StringValue("CreateEvent.Event.WeixinTitle");
			_event.WatermarkPhotoId = context.StringValue("CreateEvent.Event.WatermarkPhotoId");
			_event.StartAt = context.LongValue("CreateEvent.Event.StartAt");
			_event.EndAt = context.LongValue("CreateEvent.Event.EndAt");
			_event.Ctime = context.LongValue("CreateEvent.Event.Ctime");
			_event.Mtime = context.LongValue("CreateEvent.Event.Mtime");
			_event.ViewsCount = context.LongValue("CreateEvent.Event.ViewsCount");
			_event.LibraryId = context.StringValue("CreateEvent.Event.LibraryId");
			_event.IdStr1 = context.StringValue("CreateEvent.Event.IdStr");
			createEventResponse._Event = _event;
        
			return createEventResponse;
        }
    }
}