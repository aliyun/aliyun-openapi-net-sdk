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
    public class GetEventResponseUnmarshaller
    {
        public static GetEventResponse Unmarshall(UnmarshallerContext context)
        {
			GetEventResponse getEventResponse = new GetEventResponse();

			getEventResponse.HttpResponse = context.HttpResponse;
			getEventResponse.Code = context.StringValue("GetEvent.Code");
			getEventResponse.Message = context.StringValue("GetEvent.Message");
			getEventResponse.RequestId = context.StringValue("GetEvent.RequestId");
			getEventResponse.Action = context.StringValue("GetEvent.Action");

			GetEventResponse.GetEvent__Event _event = new GetEventResponse.GetEvent__Event();
			_event.Id = context.LongValue("GetEvent.Event.Id");
			_event.IdStr = context.StringValue("GetEvent.Event.IdStr");
			_event.Title = context.StringValue("GetEvent.Event.Title");
			_event.BannerPhotoId = context.StringValue("GetEvent.Event.BannerPhotoId");
			_event.Identity = context.StringValue("GetEvent.Event.Identity");
			_event.SplashPhotoId = context.StringValue("GetEvent.Event.SplashPhotoId");
			_event.State = context.StringValue("GetEvent.Event.State");
			_event.WeixinTitle = context.StringValue("GetEvent.Event.WeixinTitle");
			_event.WatermarkPhotoId = context.StringValue("GetEvent.Event.WatermarkPhotoId");
			_event.StartAt = context.LongValue("GetEvent.Event.StartAt");
			_event.EndAt = context.LongValue("GetEvent.Event.EndAt");
			_event.Ctime = context.LongValue("GetEvent.Event.Ctime");
			_event.Mtime = context.LongValue("GetEvent.Event.Mtime");
			_event.ViewsCount = context.LongValue("GetEvent.Event.ViewsCount");
			_event.LibraryId = context.StringValue("GetEvent.Event.LibraryId");
			_event.IdStr1 = context.StringValue("GetEvent.Event.IdStr");
			getEventResponse._Event = _event;
        
			return getEventResponse;
        }
    }
}
