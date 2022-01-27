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
using Aliyun.Acs.Dts.Transform;
using Aliyun.Acs.Dts.Transform.V20200101;

namespace Aliyun.Acs.Dts.Model.V20200101
{
    public class DescribeMigrationJobDetailRequest : RpcAcsRequest<DescribeMigrationJobDetailResponse>
    {
        public DescribeMigrationJobDetailRequest()
            : base("Dts", "2020-01-01", "DescribeMigrationJobDetail", "dts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private bool? migrationModeDataInitialization;

		private string migrationJobId;

		private int? pageNum;

		private string accountId;

		private bool? migrationModeDataSynchronization;

		private int? pageSize;

		private string ownerId;

		private bool? migrationModeStructureInitialization;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public bool? MigrationModeDataInitialization
		{
			get
			{
				return migrationModeDataInitialization;
			}
			set	
			{
				migrationModeDataInitialization = value;
				DictionaryUtil.Add(QueryParameters, "MigrationMode.DataInitialization", value.ToString());
			}
		}

		public string MigrationJobId
		{
			get
			{
				return migrationJobId;
			}
			set	
			{
				migrationJobId = value;
				DictionaryUtil.Add(QueryParameters, "MigrationJobId", value);
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public string AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
				DictionaryUtil.Add(QueryParameters, "AccountId", value);
			}
		}

		public bool? MigrationModeDataSynchronization
		{
			get
			{
				return migrationModeDataSynchronization;
			}
			set	
			{
				migrationModeDataSynchronization = value;
				DictionaryUtil.Add(QueryParameters, "MigrationMode.DataSynchronization", value.ToString());
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

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public bool? MigrationModeStructureInitialization
		{
			get
			{
				return migrationModeStructureInitialization;
			}
			set	
			{
				migrationModeStructureInitialization = value;
				DictionaryUtil.Add(QueryParameters, "MigrationMode.StructureInitialization", value.ToString());
			}
		}

        public override DescribeMigrationJobDetailResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeMigrationJobDetailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
