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
using Aliyun.Acs.aliyuncvc.Transform;
using Aliyun.Acs.aliyuncvc.Transform.V20191030;

namespace Aliyun.Acs.aliyuncvc.Model.V20191030
{
    public class JoinMeetingInternationalRequest : RpcAcsRequest<JoinMeetingInternationalResponse>
    {
        public JoinMeetingInternationalRequest()
            : base("aliyuncvc", "2019-10-30", "JoinMeetingInternational", "aliyuncvc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.aliyuncvc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.aliyuncvc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string userId;

		private string password;

		private string meetingCode;

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(BodyParameters, "UserId", value);
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(BodyParameters, "Password", value);
			}
		}

		public string MeetingCode
		{
			get
			{
				return meetingCode;
			}
			set	
			{
				meetingCode = value;
				DictionaryUtil.Add(BodyParameters, "MeetingCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override JoinMeetingInternationalResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return JoinMeetingInternationalResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
