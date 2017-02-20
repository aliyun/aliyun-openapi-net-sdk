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
using Aliyun.Acs.Cdn.Transform.V20141111;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class AddLivePullStreamInfoRequest : RpcAcsRequest<AddLivePullStreamInfoResponse>
    {
        public AddLivePullStreamInfoRequest()
            : base("Cdn", "2014-11-11", "AddLivePullStreamInfo")
        {
        }

		private long? _ownerId;

		private string _securityToken;

		private string _domainName;

		private string _appName;

		private string _streamName;

		private string _sourceUrl;

		private string _always;

		private string _startTime;

		private string _endTime;

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

		public string SourceUrl
		{
			get
			{
				return _sourceUrl;
			}
			set	
			{
				_sourceUrl = value;
				DictionaryUtil.Add(QueryParameters, "SourceUrl", value);
			}
		}

		public string Always
		{
			get
			{
				return _always;
			}
			set	
			{
				_always = value;
				DictionaryUtil.Add(QueryParameters, "Always", value);
			}
		}

		public string StartTime
		{
			get
			{
				return _startTime;
			}
			set	
			{
				_startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string EndTime
		{
			get
			{
				return _endTime;
			}
			set	
			{
				_endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

        public override AddLivePullStreamInfoResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AddLivePullStreamInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}