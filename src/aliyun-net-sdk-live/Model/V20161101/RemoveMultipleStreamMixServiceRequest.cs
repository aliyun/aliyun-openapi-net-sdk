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
using Aliyun.Acs.Live.Transform.V20161101;

namespace Aliyun.Acs.Live.Model.V20161101
{
    public class RemoveMultipleStreamMixServiceRequest : RpcAcsRequest<RemoveMultipleStreamMixServiceResponse>
    {
        public RemoveMultipleStreamMixServiceRequest()
            : base("Live", "2016-11-01", "RemoveMultipleStreamMixService")
        {
        }

		private string _securityToken;

		private long? _ownerId;

		private string _domainName;

		private string _appName;

		private string _streamName;

		private string _mixDomainName;

		private string _mixAppName;

		private string _mixStreamName;

		public string SecurityToken
		{
			get
			{
				return _securityToken;
			}
			set	
			{
				_securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string DomainName
		{
			get
			{
				return _domainName;
			}
			set	
			{
				_domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string AppName
		{
			get
			{
				return _appName;
			}
			set	
			{
				_appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public string StreamName
		{
			get
			{
				return _streamName;
			}
			set	
			{
				_streamName = value;
				DictionaryUtil.Add(QueryParameters, "StreamName", value);
			}
		}

		public string MixDomainName
		{
			get
			{
				return _mixDomainName;
			}
			set	
			{
				_mixDomainName = value;
				DictionaryUtil.Add(QueryParameters, "MixDomainName", value);
			}
		}

		public string MixAppName
		{
			get
			{
				return _mixAppName;
			}
			set	
			{
				_mixAppName = value;
				DictionaryUtil.Add(QueryParameters, "MixAppName", value);
			}
		}

		public string MixStreamName
		{
			get
			{
				return _mixStreamName;
			}
			set	
			{
				_mixStreamName = value;
				DictionaryUtil.Add(QueryParameters, "MixStreamName", value);
			}
		}

        public override RemoveMultipleStreamMixServiceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return RemoveMultipleStreamMixServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}