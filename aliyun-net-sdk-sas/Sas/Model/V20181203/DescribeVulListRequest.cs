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
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class DescribeVulListRequest : RpcAcsRequest<DescribeVulListResponse>
    {
        public DescribeVulListRequest()
            : base("Sas", "2018-12-03", "DescribeVulList", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string targetType;

		private int? minScore;

		private string remark;

		private string attachTypes;

		private string type;

		private string vpcInstanceIds;

		private long? createTsStart;

		private string containerFieldName;

		private string containerFieldValue;

		private int? pageSize;

		private long? modifyTsStart;

		private string lang;

		private long? modifyTsEnd;

		private string level;

		private string resource;

		private string groupId;

		private string dealed;

		private int? currentPage;

		private string clusterId;

		private string batchName;

		private string aliasName;

		private long? createTsEnd;

		private string necessity;

		private string uuids;

		public string TargetType
		{
			get
			{
				return targetType;
			}
			set	
			{
				targetType = value;
				DictionaryUtil.Add(QueryParameters, "TargetType", value);
			}
		}

		public int? MinScore
		{
			get
			{
				return minScore;
			}
			set	
			{
				minScore = value;
				DictionaryUtil.Add(QueryParameters, "MinScore", value.ToString());
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public string AttachTypes
		{
			get
			{
				return attachTypes;
			}
			set	
			{
				attachTypes = value;
				DictionaryUtil.Add(QueryParameters, "AttachTypes", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string VpcInstanceIds
		{
			get
			{
				return vpcInstanceIds;
			}
			set	
			{
				vpcInstanceIds = value;
				DictionaryUtil.Add(QueryParameters, "VpcInstanceIds", value);
			}
		}

		public long? CreateTsStart
		{
			get
			{
				return createTsStart;
			}
			set	
			{
				createTsStart = value;
				DictionaryUtil.Add(QueryParameters, "CreateTsStart", value.ToString());
			}
		}

		public string ContainerFieldName
		{
			get
			{
				return containerFieldName;
			}
			set	
			{
				containerFieldName = value;
				DictionaryUtil.Add(QueryParameters, "ContainerFieldName", value);
			}
		}

		public string ContainerFieldValue
		{
			get
			{
				return containerFieldValue;
			}
			set	
			{
				containerFieldValue = value;
				DictionaryUtil.Add(QueryParameters, "ContainerFieldValue", value);
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

		public long? ModifyTsStart
		{
			get
			{
				return modifyTsStart;
			}
			set	
			{
				modifyTsStart = value;
				DictionaryUtil.Add(QueryParameters, "ModifyTsStart", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public long? ModifyTsEnd
		{
			get
			{
				return modifyTsEnd;
			}
			set	
			{
				modifyTsEnd = value;
				DictionaryUtil.Add(QueryParameters, "ModifyTsEnd", value.ToString());
			}
		}

		public string Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
				DictionaryUtil.Add(QueryParameters, "Level", value);
			}
		}

		public string Resource
		{
			get
			{
				return resource;
			}
			set	
			{
				resource = value;
				DictionaryUtil.Add(QueryParameters, "Resource", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string Dealed
		{
			get
			{
				return dealed;
			}
			set	
			{
				dealed = value;
				DictionaryUtil.Add(QueryParameters, "Dealed", value);
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
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

		public string BatchName
		{
			get
			{
				return batchName;
			}
			set	
			{
				batchName = value;
				DictionaryUtil.Add(QueryParameters, "BatchName", value);
			}
		}

		public string AliasName
		{
			get
			{
				return aliasName;
			}
			set	
			{
				aliasName = value;
				DictionaryUtil.Add(QueryParameters, "AliasName", value);
			}
		}

		public long? CreateTsEnd
		{
			get
			{
				return createTsEnd;
			}
			set	
			{
				createTsEnd = value;
				DictionaryUtil.Add(QueryParameters, "CreateTsEnd", value.ToString());
			}
		}

		public string Necessity
		{
			get
			{
				return necessity;
			}
			set	
			{
				necessity = value;
				DictionaryUtil.Add(QueryParameters, "Necessity", value);
			}
		}

		public string Uuids
		{
			get
			{
				return uuids;
			}
			set	
			{
				uuids = value;
				DictionaryUtil.Add(QueryParameters, "Uuids", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeVulListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeVulListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
