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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class ContextQueryLogRequest : RpcAcsRequest<ContextQueryLogResponse>
    {
        public ContextQueryLogRequest()
            : base("Emr", "2016-04-08", "ContextQueryLog", "emr", "openAPI")
        {
        }

		private string packId;

		private long? resourceOwnerId;

		private int? totalOffset;

		private int? size;

		private string regionId;

		private string packMeta;

		private int? from;

		private string clusterId;

		private int? to;

		private bool? reverse;

		private string logStore;

		private string accessKeyId;

		public string PackId
		{
			get
			{
				return packId;
			}
			set	
			{
				packId = value;
				DictionaryUtil.Add(QueryParameters, "PackId", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public int? TotalOffset
		{
			get
			{
				return totalOffset;
			}
			set	
			{
				totalOffset = value;
				DictionaryUtil.Add(QueryParameters, "TotalOffset", value.ToString());
			}
		}

		public int? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "Size", value.ToString());
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public string PackMeta
		{
			get
			{
				return packMeta;
			}
			set	
			{
				packMeta = value;
				DictionaryUtil.Add(QueryParameters, "PackMeta", value);
			}
		}

		public int? From
		{
			get
			{
				return from;
			}
			set	
			{
				from = value;
				DictionaryUtil.Add(QueryParameters, "From", value.ToString());
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public int? To
		{
			get
			{
				return to;
			}
			set	
			{
				to = value;
				DictionaryUtil.Add(QueryParameters, "To", value.ToString());
			}
		}

		public bool? Reverse
		{
			get
			{
				return reverse;
			}
			set	
			{
				reverse = value;
				DictionaryUtil.Add(QueryParameters, "Reverse", value.ToString());
			}
		}

		public string LogStore
		{
			get
			{
				return logStore;
			}
			set	
			{
				logStore = value;
				DictionaryUtil.Add(QueryParameters, "LogStore", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override ContextQueryLogResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ContextQueryLogResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
