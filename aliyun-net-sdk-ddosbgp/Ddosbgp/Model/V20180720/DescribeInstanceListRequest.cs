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
using Aliyun.Acs.ddosbgp;
using Aliyun.Acs.ddosbgp.Transform;
using Aliyun.Acs.ddosbgp.Transform.V20180720;

namespace Aliyun.Acs.ddosbgp.Model.V20180720
{
    public class DescribeInstanceListRequest : RpcAcsRequest<DescribeInstanceListResponse>
    {
        public DescribeInstanceListRequest()
            : base("ddosbgp", "2018-07-20", "DescribeInstanceList")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ddosbgp.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ddosbgp.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string remark;

		private string resourceGroupId;

		private int? pageSize;

		private string instanceType;

		private string ipVersion;

		private List<string> tags = new List<string>(){ };

		private string ip;

		private string orderby;

		private string instanceIdList;

		private int? pageNo;

		private string orderdire;

		private List<string> instanceTypeList = new List<string>(){ };

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

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
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

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string IpVersion
		{
			get
			{
				return ipVersion;
			}
			set	
			{
				ipVersion = value;
				DictionaryUtil.Add(QueryParameters, "IpVersion", value);
			}
		}

		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
					}
				}
			}
		}

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
				DictionaryUtil.Add(QueryParameters, "Ip", value);
			}
		}

		public string Orderby
		{
			get
			{
				return orderby;
			}
			set	
			{
				orderby = value;
				DictionaryUtil.Add(QueryParameters, "Orderby", value);
			}
		}

		public string InstanceIdList
		{
			get
			{
				return instanceIdList;
			}
			set	
			{
				instanceIdList = value;
				DictionaryUtil.Add(QueryParameters, "InstanceIdList", value);
			}
		}

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(QueryParameters, "PageNo", value.ToString());
			}
		}

		public string Orderdire
		{
			get
			{
				return orderdire;
			}
			set	
			{
				orderdire = value;
				DictionaryUtil.Add(QueryParameters, "Orderdire", value);
			}
		}

		public List<string> InstanceTypeList
		{
			get
			{
				return instanceTypeList;
			}

			set
			{
				instanceTypeList = value;
				if(instanceTypeList != null)
				{
					for (int depth1 = 0; depth1 < instanceTypeList.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"InstanceTypeList." + (depth1 + 1), instanceTypeList[depth1]);
					}
				}
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeInstanceListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeInstanceListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
