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
using Aliyun.Acs.ddoscoo;
using Aliyun.Acs.ddoscoo.Transform;
using Aliyun.Acs.ddoscoo.Transform.V20200101;

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
    public class DescribeInstancesRequest : RpcAcsRequest<DescribeInstancesResponse>
    {
        public DescribeInstancesRequest()
            : base("ddoscoo", "2020-01-01", "DescribeInstances")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? edition;

		private string remark;

		private string pageNumber;

		private int? enabled;

		private string resourceGroupId;

		private string pageSize;

		private List<Tag> tags = new List<Tag>(){ };

		private long? expireStartTime;

		private long? expireEndTime;

		private string ip;

		private List<string> instanceIdss = new List<string>(){ };

		private List<int?> statuss = new List<int?>(){ };

		public int? Edition
		{
			get
			{
				return edition;
			}
			set	
			{
				edition = value;
				DictionaryUtil.Add(QueryParameters, "Edition", value.ToString());
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

		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value);
			}
		}

		public int? Enabled
		{
			get
			{
				return enabled;
			}
			set	
			{
				enabled = value;
				DictionaryUtil.Add(QueryParameters, "Enabled", value.ToString());
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

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value);
			}
		}

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
				}
			}
		}

		public long? ExpireStartTime
		{
			get
			{
				return expireStartTime;
			}
			set	
			{
				expireStartTime = value;
				DictionaryUtil.Add(QueryParameters, "ExpireStartTime", value.ToString());
			}
		}

		public long? ExpireEndTime
		{
			get
			{
				return expireEndTime;
			}
			set	
			{
				expireEndTime = value;
				DictionaryUtil.Add(QueryParameters, "ExpireEndTime", value.ToString());
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

		public List<string> InstanceIdss
		{
			get
			{
				return instanceIdss;
			}

			set
			{
				instanceIdss = value;
				for (int i = 0; i < instanceIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceIds." + (i + 1) , instanceIdss[i]);
				}
			}
		}

		public List<int?> Statuss
		{
			get
			{
				return statuss;
			}

			set
			{
				statuss = value;
				for (int i = 0; i < statuss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Status." + (i + 1) , statuss[i]);
				}
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			public string Value
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

        public override DescribeInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
