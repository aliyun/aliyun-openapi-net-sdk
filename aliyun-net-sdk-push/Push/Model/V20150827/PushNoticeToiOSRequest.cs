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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Push.Transform;
using Aliyun.Acs.Push.Transform.V20150827;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Model.V20150827
{
    public class PushNoticeToiOSRequest : RpcAcsRequest<PushNoticeToiOSResponse>
    {
        public PushNoticeToiOSRequest()
            : base("Push", "2015-08-27", "PushNoticeToiOS")
        {
        }

		private long? appKey;

		private string target;

		private string targetValue;

		private string ext;

		private string env;

		private string summary;

		private string iOSExtParameters;

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

		public string Ext
		{
			get
			{
				return ext;
			}
			set	
			{
				ext = value;
				DictionaryUtil.Add(QueryParameters, "Ext", value);
			}
		}

		public string Env
		{
			get
			{
				return env;
			}
			set	
			{
				env = value;
				DictionaryUtil.Add(QueryParameters, "Env", value);
			}
		}

		public string Summary
		{
			get
			{
				return summary;
			}
			set	
			{
				summary = value;
				DictionaryUtil.Add(QueryParameters, "Summary", value);
			}
		}

		public string IOSExtParameters
		{
			get
			{
				return iOSExtParameters;
			}
			set	
			{
				iOSExtParameters = value;
				DictionaryUtil.Add(QueryParameters, "iOSExtParameters", value);
			}
		}

        public override PushNoticeToiOSResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return PushNoticeToiOSResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}