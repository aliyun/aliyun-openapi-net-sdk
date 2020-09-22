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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class TriggerRecordRequest : RpcAcsRequest<TriggerRecordResponse>
    {
        public TriggerRecordRequest()
            : base("live", "2016-11-01", "TriggerRecord", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? source;

		private string userData;

		private string appName;

		private string streamName;

		private string avMode;

		private string storePath;

		private string domainName;

		private long? ownerId;

		private string forceTranscode;

		private bool? needRecord;

		public int? Source
		{
			get
			{
				return source;
			}
			set	
			{
				source = value;
				DictionaryUtil.Add(QueryParameters, "Source", value.ToString());
			}
		}

		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
				DictionaryUtil.Add(QueryParameters, "UserData", value);
			}
		}

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public string StreamName
		{
			get
			{
				return streamName;
			}
			set	
			{
				streamName = value;
				DictionaryUtil.Add(QueryParameters, "StreamName", value);
			}
		}

		public string AvMode
		{
			get
			{
				return avMode;
			}
			set	
			{
				avMode = value;
				DictionaryUtil.Add(QueryParameters, "AvMode", value);
			}
		}

		public string StorePath
		{
			get
			{
				return storePath;
			}
			set	
			{
				storePath = value;
				DictionaryUtil.Add(QueryParameters, "StorePath", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
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

		public string ForceTranscode
		{
			get
			{
				return forceTranscode;
			}
			set	
			{
				forceTranscode = value;
				DictionaryUtil.Add(QueryParameters, "ForceTranscode", value);
			}
		}

		public bool? NeedRecord
		{
			get
			{
				return needRecord;
			}
			set	
			{
				needRecord = value;
				DictionaryUtil.Add(QueryParameters, "NeedRecord", value.ToString());
			}
		}

        public override TriggerRecordResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TriggerRecordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
