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
using Aliyun.Acs.ivpd.Transform;
using Aliyun.Acs.ivpd.Transform.V20190625;

namespace Aliyun.Acs.ivpd.Model.V20190625
{
    public class UpdateUserBucketConfigRequest : RpcAcsRequest<UpdateUserBucketConfigResponse>
    {
        public UpdateUserBucketConfigRequest()
            : base("ivpd", "2019-06-25", "UpdateUserBucketConfig", "ivpd", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<Data> datas = new List<Data>(){ };

		public List<Data> Datas
		{
			get
			{
				return datas;
			}

			set
			{
				datas = value;
				for (int i = 0; i < datas.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Data." + (i + 1) + ".Bucket", datas[i].Bucket);
					DictionaryUtil.Add(BodyParameters,"Data." + (i + 1) + ".Region", datas[i].Region);
				}
			}
		}

		public class Data
		{

			private string bucket;

			private string region;

			public string Bucket
			{
				get
				{
					return bucket;
				}
				set	
				{
					bucket = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateUserBucketConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateUserBucketConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
