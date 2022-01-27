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
using Aliyun.Acs.Dbs.Transform;
using Aliyun.Acs.Dbs.Transform.V20190306;

namespace Aliyun.Acs.Dbs.Model.V20190306
{
    public class CreateBackupPlanRequest : RpcAcsRequest<CreateBackupPlanResponse>
    {
        public CreateBackupPlanRequest()
            : base("Dbs", "2019-03-06", "CreateBackupPlan", "cbs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dbs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dbs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string databaseType;

		private string clientToken;

		private string instanceClass;

		private string storageType;

		private string databaseRegion;

		private string instanceType;

		private string period;

		private string fromApp;

		private string ownerId;

		private int? usedTime;

		private string backupMethod;

		private string storageRegion;

		private string region;

		private string payType;

		public string DatabaseType
		{
			get
			{
				return databaseType;
			}
			set	
			{
				databaseType = value;
				DictionaryUtil.Add(QueryParameters, "DatabaseType", value);
			}
		}

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

		public string InstanceClass
		{
			get
			{
				return instanceClass;
			}
			set	
			{
				instanceClass = value;
				DictionaryUtil.Add(QueryParameters, "InstanceClass", value);
			}
		}

		public string StorageType
		{
			get
			{
				return storageType;
			}
			set	
			{
				storageType = value;
				DictionaryUtil.Add(QueryParameters, "StorageType", value);
			}
		}

		public string DatabaseRegion
		{
			get
			{
				return databaseRegion;
			}
			set	
			{
				databaseRegion = value;
				DictionaryUtil.Add(QueryParameters, "DatabaseRegion", value);
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

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value);
			}
		}

		public string FromApp
		{
			get
			{
				return fromApp;
			}
			set	
			{
				fromApp = value;
				DictionaryUtil.Add(QueryParameters, "FromApp", value);
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

		public int? UsedTime
		{
			get
			{
				return usedTime;
			}
			set	
			{
				usedTime = value;
				DictionaryUtil.Add(QueryParameters, "UsedTime", value.ToString());
			}
		}

		public string BackupMethod
		{
			get
			{
				return backupMethod;
			}
			set	
			{
				backupMethod = value;
				DictionaryUtil.Add(QueryParameters, "BackupMethod", value);
			}
		}

		public string StorageRegion
		{
			get
			{
				return storageRegion;
			}
			set	
			{
				storageRegion = value;
				DictionaryUtil.Add(QueryParameters, "StorageRegion", value);
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
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
				DictionaryUtil.Add(QueryParameters, "PayType", value);
			}
		}

        public override CreateBackupPlanResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateBackupPlanResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
