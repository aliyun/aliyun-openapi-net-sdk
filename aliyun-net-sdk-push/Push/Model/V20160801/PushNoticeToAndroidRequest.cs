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
using Aliyun.Acs.Push;
using Aliyun.Acs.Push.Transform;
using Aliyun.Acs.Push.Transform.V20160801;

namespace Aliyun.Acs.Push.Model.V20160801
{
    public class PushNoticeToAndroidRequest : RpcAcsRequest<PushNoticeToAndroidResponse>
    {
        public PushNoticeToAndroidRequest()
            : base("Push", "2016-08-01", "PushNoticeToAndroid")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Push.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Push.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string title;

		private string body;

		private string extParameters;

		private bool? storeOffline;

		private string jobKey;

		private string target;

		private long? appKey;

		private string targetValue;

		public string Title
		{
			get
			{
				return title;
			}
			set	
			{
				title = value;
				DictionaryUtil.Add(QueryParameters, "Title", value);
			}
		}

		public string Body
		{
			get
			{
				return body;
			}
			set	
			{
				body = value;
				DictionaryUtil.Add(QueryParameters, "Body", value);
			}
		}

		public string ExtParameters
		{
			get
			{
				return extParameters;
			}
			set	
			{
				extParameters = value;
				DictionaryUtil.Add(QueryParameters, "ExtParameters", value);
			}
		}

		public bool? StoreOffline
		{
			get
			{
				return storeOffline;
			}
			set	
			{
				storeOffline = value;
				DictionaryUtil.Add(QueryParameters, "StoreOffline", value.ToString());
			}
		}

		public string JobKey
		{
			get
			{
				return jobKey;
			}
			set	
			{
				jobKey = value;
				DictionaryUtil.Add(QueryParameters, "JobKey", value);
			}
		}

		public string Target
		{
			get
			{
				return target;
			}
			set	
			{
				target = value;
				DictionaryUtil.Add(QueryParameters, "Target", value);
			}
		}

		public long? AppKey
		{
			get
			{
				return appKey;
			}
			set	
			{
				appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value.ToString());
			}
		}

		public string TargetValue
		{
			get
			{
				return targetValue;
			}
			set	
			{
				targetValue = value;
				DictionaryUtil.Add(QueryParameters, "TargetValue", value);
			}
		}

        public override PushNoticeToAndroidResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PushNoticeToAndroidResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
