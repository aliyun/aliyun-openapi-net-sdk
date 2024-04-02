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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class UpdateNotificationSettingRequest : RpcAcsRequest<UpdateNotificationSettingResponse>
    {
        public UpdateNotificationSettingRequest()
            : base("Green", "2017-08-23", "UpdateNotificationSetting", "green", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string realtimeMessageList;

		private int? scheduleMessageTime;

		private string sourceIp;

		private string reminderModeList;

		private string lang;

		private int? scheduleMessageTimeZone;

		public string RealtimeMessageList
		{
			get
			{
				return realtimeMessageList;
			}
			set	
			{
				realtimeMessageList = value;
				DictionaryUtil.Add(QueryParameters, "RealtimeMessageList", value);
			}
		}

		public int? ScheduleMessageTime
		{
			get
			{
				return scheduleMessageTime;
			}
			set	
			{
				scheduleMessageTime = value;
				DictionaryUtil.Add(QueryParameters, "ScheduleMessageTime", value.ToString());
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string ReminderModeList
		{
			get
			{
				return reminderModeList;
			}
			set	
			{
				reminderModeList = value;
				DictionaryUtil.Add(QueryParameters, "ReminderModeList", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public int? ScheduleMessageTimeZone
		{
			get
			{
				return scheduleMessageTimeZone;
			}
			set	
			{
				scheduleMessageTimeZone = value;
				DictionaryUtil.Add(QueryParameters, "ScheduleMessageTimeZone", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateNotificationSettingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateNotificationSettingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
