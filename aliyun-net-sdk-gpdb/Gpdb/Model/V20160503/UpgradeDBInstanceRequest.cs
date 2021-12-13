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
using Aliyun.Acs.gpdb;
using Aliyun.Acs.gpdb.Transform;
using Aliyun.Acs.gpdb.Transform.V20160503;

namespace Aliyun.Acs.gpdb.Model.V20160503
{
    public class UpgradeDBInstanceRequest : RpcAcsRequest<UpgradeDBInstanceResponse>
    {
        public UpgradeDBInstanceRequest()
            : base("gpdb", "2016-05-03", "UpgradeDBInstance")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.gpdb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.gpdb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dBInstanceId;

		private string dBInstanceGroupCount;

		private long? ownerId;

		private string dBInstanceClass;

		private string payType;

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string DBInstanceGroupCount
		{
			get
			{
				return dBInstanceGroupCount;
			}
			set	
			{
				dBInstanceGroupCount = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceGroupCount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string DBInstanceClass
		{
			get
			{
				return dBInstanceClass;
			}
			set	
			{
				dBInstanceClass = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceClass", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpgradeDBInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpgradeDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
