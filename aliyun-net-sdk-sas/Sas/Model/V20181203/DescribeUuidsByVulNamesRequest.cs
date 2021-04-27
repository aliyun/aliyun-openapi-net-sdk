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
    public class DescribeUuidsByVulNamesRequest : RpcAcsRequest<DescribeUuidsByVulNamesResponse>
    {
        public DescribeUuidsByVulNamesRequest()
            : base("Sas", "2018-12-03", "DescribeUuidsByVulNames", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string statusList;

		private string targetType;

		private string remark;

		private string type;

		private string vpcInstanceIds;

		private List<string> vulNamess = new List<string>(){ };

		private string tag;

		private string lang;

		private string level;

		private long? groupId;

		private string dealed;

		private string fieldValue;

		private string fieldName;

		private string searchTags;

		private string necessity;

		public string StatusList
		{
			get
			{
				return statusList;
			}
			set	
			{
				statusList = value;
				DictionaryUtil.Add(QueryParameters, "StatusList", value);
			}
		}

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

		public List<string> VulNamess
		{
			get
			{
				return vulNamess;
			}

			set
			{
				vulNamess = value;
				for (int i = 0; i < vulNamess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"VulNames." + (i + 1) , vulNamess[i]);
				}
			}
		}

		public string Tag
		{
			get
			{
				return tag;
			}
			set	
			{
				tag = value;
				DictionaryUtil.Add(QueryParameters, "Tag", value);
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

		public long? GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value.ToString());
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

		public string FieldValue
		{
			get
			{
				return fieldValue;
			}
			set	
			{
				fieldValue = value;
				DictionaryUtil.Add(QueryParameters, "FieldValue", value);
			}
		}

		public string FieldName
		{
			get
			{
				return fieldName;
			}
			set	
			{
				fieldName = value;
				DictionaryUtil.Add(QueryParameters, "FieldName", value);
			}
		}

		public string SearchTags
		{
			get
			{
				return searchTags;
			}
			set	
			{
				searchTags = value;
				DictionaryUtil.Add(QueryParameters, "SearchTags", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeUuidsByVulNamesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeUuidsByVulNamesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
