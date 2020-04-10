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
using Aliyun.Acs.digitalstore.Transform;
using Aliyun.Acs.digitalstore.Transform.V20200107;

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
    public class CreateRoleRequest : RpcAcsRequest<CreateRoleResponse>
    {
        public CreateRoleRequest()
            : base("digitalstore", "2020-01-07", "CreateRole", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private List<Apis> apiss = new List<Apis>(){ };

		private string name;

		private List<Menus> menuss = new List<Menus>(){ };

		private int? status;

		public List<Apis> Apiss
		{
			get
			{
				return apiss;
			}

			set
			{
				apiss = value;
				for (int i = 0; i < apiss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Apis." + (i + 1) + ".Name", apiss[i].Name);
					DictionaryUtil.Add(BodyParameters,"Apis." + (i + 1) + ".Id", apiss[i].Id);
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
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public List<Menus> Menuss
		{
			get
			{
				return menuss;
			}

			set
			{
				menuss = value;
				for (int i = 0; i < menuss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Menus." + (i + 1) + ".Name", menuss[i].Name);
					DictionaryUtil.Add(BodyParameters,"Menus." + (i + 1) + ".Id", menuss[i].Id);
				}
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value.ToString());
			}
		}

		public class Apis
		{

			private string name;

			private string id;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}
		}

		public class Menus
		{

			private string name;

			private string id;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}
		}

        public override CreateRoleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRoleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
