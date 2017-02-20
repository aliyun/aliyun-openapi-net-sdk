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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Push.Transform.V20150827;

namespace Aliyun.Acs.Push.Model.V20150827
{
    public class PushNoticeToiOsRequest : RpcAcsRequest<PushNoticeToiOsResponse>
    {
        public PushNoticeToiOsRequest()
            : base("Push", "2015-08-27", "PushNoticeToiOS")
        {
        }

		private long? _appKey;

		private string _target;

		private string _targetValue;

		private string _ext;

		private string _env;

		private string _summary;

		private string _iOsExtParameters;

		public long? AppKey
		{
			get
			{
				return _appKey;
			}
			set	
			{
				_appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value.ToString());
			}
		}

		public string Target
		{
			get
			{
				return _target;
			}
			set	
			{
				_target = value;
				DictionaryUtil.Add(QueryParameters, "Target", value);
			}
		}

		public string TargetValue
		{
			get
			{
				return _targetValue;
			}
			set	
			{
				_targetValue = value;
				DictionaryUtil.Add(QueryParameters, "TargetValue", value);
			}
		}

		public string Ext
		{
			get
			{
				return _ext;
			}
			set	
			{
				_ext = value;
				DictionaryUtil.Add(QueryParameters, "Ext", value);
			}
		}

		public string Env
		{
			get
			{
				return _env;
			}
			set	
			{
				_env = value;
				DictionaryUtil.Add(QueryParameters, "Env", value);
			}
		}

		public string Summary
		{
			get
			{
				return _summary;
			}
			set	
			{
				_summary = value;
				DictionaryUtil.Add(QueryParameters, "Summary", value);
			}
		}

		public string IosExtParameters
		{
			get
			{
				return _iOsExtParameters;
			}
			set	
			{
				_iOsExtParameters = value;
				DictionaryUtil.Add(QueryParameters, "iOSExtParameters", value);
			}
		}

        public override PushNoticeToiOsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return PushNoticeToiOsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}