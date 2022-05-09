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
    public class ListClusterServiceConfigHistoryRequest : RpcAcsRequest<ListClusterServiceConfigHistoryResponse>
    {
        public ListClusterServiceConfigHistoryRequest()
            : base("Emr", "2016-04-08", "ListClusterServiceConfigHistory", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string hostInstanceId;

		private int? pageNumber;

		private string configVersion;

		private int? pageSize;

		private string serviceName;

		private string author;

		private string clusterId;

		private string configFileName;

		private string configItemKey;

		private string hostGroupId;

		private string comment;

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

		public string HostInstanceId
		{
			get
			{
				return hostInstanceId;
			}
			set	
			{
				hostInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "HostInstanceId", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string ConfigVersion
		{
			get
			{
				return configVersion;
			}
			set	
			{
				configVersion = value;
				DictionaryUtil.Add(QueryParameters, "ConfigVersion", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public string Author
		{
			get
			{
				return author;
			}
			set	
			{
				author = value;
				DictionaryUtil.Add(QueryParameters, "Author", value);
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

		public string ConfigFileName
		{
			get
			{
				return configFileName;
			}
			set	
			{
				configFileName = value;
				DictionaryUtil.Add(QueryParameters, "ConfigFileName", value);
			}
		}

		public string ConfigItemKey
		{
			get
			{
				return configItemKey;
			}
			set	
			{
				configItemKey = value;
				DictionaryUtil.Add(QueryParameters, "ConfigItemKey", value);
			}
		}

		public string HostGroupId
		{
			get
			{
				return hostGroupId;
			}
			set	
			{
				hostGroupId = value;
				DictionaryUtil.Add(QueryParameters, "HostGroupId", value);
			}
		}

		public string Comment
		{
			get
			{
				return comment;
			}
			set	
			{
				comment = value;
				DictionaryUtil.Add(QueryParameters, "Comment", value);
			}
		}

        public override ListClusterServiceConfigHistoryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListClusterServiceConfigHistoryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
