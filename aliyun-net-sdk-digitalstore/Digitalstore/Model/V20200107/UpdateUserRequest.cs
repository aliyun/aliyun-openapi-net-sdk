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
    public class UpdateUserRequest : RpcAcsRequest<UpdateUserResponse>
    {
        public UpdateUserRequest()
            : base("digitalstore", "2020-01-07", "UpdateUser", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string mail;

		private List<Roles> roless = new List<Roles>(){ };

		private string remark;

		private List<Factories> factoriess = new List<Factories>(){ };

		private long? userId;

		private List<Stores> storess = new List<Stores>(){ };

		private List<Warehouses> warehousess = new List<Warehouses>(){ };

		private string telephone;

		private string userName;

		private int? status;

		public string Mail
		{
			get
			{
				return mail;
			}
			set	
			{
				mail = value;
				DictionaryUtil.Add(BodyParameters, "Mail", value);
			}
		}

		public List<Roles> Roless
		{
			get
			{
				return roless;
			}

			set
			{
				roless = value;
				for (int i = 0; i < roless.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Roles." + (i + 1) + ".RoleName", roless[i].RoleName);
					DictionaryUtil.Add(BodyParameters,"Roles." + (i + 1) + ".RoleId", roless[i].RoleId);
				}
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
				DictionaryUtil.Add(BodyParameters, "Remark", value);
			}
		}

		public List<Factories> Factoriess
		{
			get
			{
				return factoriess;
			}

			set
			{
				factoriess = value;
				for (int i = 0; i < factoriess.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Factories." + (i + 1) + ".UnitId", factoriess[i].UnitId);
				}
			}
		}

		public long? UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(BodyParameters, "UserId", value.ToString());
			}
		}

		public List<Stores> Storess
		{
			get
			{
				return storess;
			}

			set
			{
				storess = value;
				for (int i = 0; i < storess.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Stores." + (i + 1) + ".UnitId", storess[i].UnitId);
				}
			}
		}

		public List<Warehouses> Warehousess
		{
			get
			{
				return warehousess;
			}

			set
			{
				warehousess = value;
				for (int i = 0; i < warehousess.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Warehouses." + (i + 1) + ".UnitId", warehousess[i].UnitId);
				}
			}
		}

		public string Telephone
		{
			get
			{
				return telephone;
			}
			set	
			{
				telephone = value;
				DictionaryUtil.Add(BodyParameters, "Telephone", value);
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(BodyParameters, "UserName", value);
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

		public class Roles
		{

			private string roleName;

			private string roleId;

			public string RoleName
			{
				get
				{
					return roleName;
				}
				set	
				{
					roleName = value;
				}
			}

			public string RoleId
			{
				get
				{
					return roleId;
				}
				set	
				{
					roleId = value;
				}
			}
		}

		public class Factories
		{

			private string unitId;

			public string UnitId
			{
				get
				{
					return unitId;
				}
				set	
				{
					unitId = value;
				}
			}
		}

		public class Stores
		{

			private string unitId;

			public string UnitId
			{
				get
				{
					return unitId;
				}
				set	
				{
					unitId = value;
				}
			}
		}

		public class Warehouses
		{

			private string unitId;

			public string UnitId
			{
				get
				{
					return unitId;
				}
				set	
				{
					unitId = value;
				}
			}
		}

        public override UpdateUserResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
