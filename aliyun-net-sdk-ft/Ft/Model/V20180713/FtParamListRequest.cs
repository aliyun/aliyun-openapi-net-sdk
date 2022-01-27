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
using Aliyun.Acs.Ft;
using Aliyun.Acs.Ft.Transform;
using Aliyun.Acs.Ft.Transform.V20180713;

namespace Aliyun.Acs.Ft.Model.V20180713
{
    public class FtParamListRequest : RpcAcsRequest<FtParamListResponse>
    {
        public FtParamListRequest()
            : base("Ft", "2018-07-13", "FtParamList")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<Disk> disks = new List<Disk>(){ };

		private string name;

		public List<Disk> Disks
		{
			get
			{
				return disks;
			}

			set
			{
				disks = value;
				for (int i = 0; i < disks.Count; i++)
				{
					for (int j = 0; j < disks[i].Sizes.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"Disk." + (i + 1) + ".Size." +(j + 1), disks[i].Sizes[j]);
					}
					for (int j = 0; j < disks[i].Types.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"Disk." + (i + 1) + ".Type." +(j + 1), disks[i].Types[j]);
					}
				}
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public class Disk
		{

			private List<string> sizes = new List<string>(){ };

			private List<string> types = new List<string>(){ };

			public List<string> Sizes
			{
				get
				{
					return sizes;
				}
				set	
				{
					sizes = value;
				}
			}

			public List<string> Types
			{
				get
				{
					return types;
				}
				set	
				{
					types = value;
				}
			}
		}

        public override FtParamListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return FtParamListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
