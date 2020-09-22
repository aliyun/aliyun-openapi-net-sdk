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
using Aliyun.Acs.rtc.Transform;
using Aliyun.Acs.rtc.Transform.V20180111;

namespace Aliyun.Acs.rtc.Model.V20180111
{
    public class CreateMAURuleRequest : RpcAcsRequest<CreateMAURuleResponse>
    {
        public CreateMAURuleRequest()
            : base("rtc", "2018-01-11", "CreateMAURule", "rtc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string useridPrefix;

		private string channelPrefix;

		private long? ownerId;

		private long? mauTemplateId;

		private string appId;

		private string callBack;

		public string UseridPrefix
		{
			get
			{
				return useridPrefix;
			}
			set	
			{
				useridPrefix = value;
				DictionaryUtil.Add(QueryParameters, "UseridPrefix", value);
			}
		}

		public string ChannelPrefix
		{
			get
			{
				return channelPrefix;
			}
			set	
			{
				channelPrefix = value;
				DictionaryUtil.Add(QueryParameters, "ChannelPrefix", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public long? MauTemplateId
		{
			get
			{
				return mauTemplateId;
			}
			set	
			{
				mauTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "MauTemplateId", value.ToString());
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string CallBack
		{
			get
			{
				return callBack;
			}
			set	
			{
				callBack = value;
				DictionaryUtil.Add(QueryParameters, "CallBack", value);
			}
		}

        public override CreateMAURuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateMAURuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
