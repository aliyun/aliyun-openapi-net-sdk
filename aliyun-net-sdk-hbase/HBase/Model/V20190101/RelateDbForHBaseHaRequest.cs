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
using Aliyun.Acs.HBase.Transform;
using Aliyun.Acs.HBase.Transform.V20190101;

namespace Aliyun.Acs.HBase.Model.V20190101
{
    public class RelateDbForHBaseHaRequest : RpcAcsRequest<RelateDbForHBaseHaResponse>
    {
        public RelateDbForHBaseHaRequest()
            : base("HBase", "2019-01-01", "RelateDbForHBaseHa", "hbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string haMigrateType;

		private string haActiveHdfsUri;

		private string haStandbyVersion;

		private bool? isStandbyStandard;

		private string haActiveClusterKey;

		private string haStandbyPassword;

		private string haStandbyClusterKey;

		private string haStandbyHbaseFsDir;

		private string haActiveHbaseFsDir;

		private string haActiveDBType;

		private string haActivePassword;

		private bool? isActiveStandard;

		private string haStandbyUser;

		private string haActive;

		private string haStandby;

		private string haStandbyHdfsUri;

		private string haActiveVersion;

		private string clusterId;

		private string haStandbyDBType;

		private string haTables;

		private string haActiveUser;

		public string HaMigrateType
		{
			get
			{
				return haMigrateType;
			}
			set	
			{
				haMigrateType = value;
				DictionaryUtil.Add(QueryParameters, "HaMigrateType", value);
			}
		}

		public string HaActiveHdfsUri
		{
			get
			{
				return haActiveHdfsUri;
			}
			set	
			{
				haActiveHdfsUri = value;
				DictionaryUtil.Add(QueryParameters, "HaActiveHdfsUri", value);
			}
		}

		public string HaStandbyVersion
		{
			get
			{
				return haStandbyVersion;
			}
			set	
			{
				haStandbyVersion = value;
				DictionaryUtil.Add(QueryParameters, "HaStandbyVersion", value);
			}
		}

		public bool? IsStandbyStandard
		{
			get
			{
				return isStandbyStandard;
			}
			set	
			{
				isStandbyStandard = value;
				DictionaryUtil.Add(QueryParameters, "IsStandbyStandard", value.ToString());
			}
		}

		public string HaActiveClusterKey
		{
			get
			{
				return haActiveClusterKey;
			}
			set	
			{
				haActiveClusterKey = value;
				DictionaryUtil.Add(QueryParameters, "HaActiveClusterKey", value);
			}
		}

		public string HaStandbyPassword
		{
			get
			{
				return haStandbyPassword;
			}
			set	
			{
				haStandbyPassword = value;
				DictionaryUtil.Add(QueryParameters, "HaStandbyPassword", value);
			}
		}

		public string HaStandbyClusterKey
		{
			get
			{
				return haStandbyClusterKey;
			}
			set	
			{
				haStandbyClusterKey = value;
				DictionaryUtil.Add(QueryParameters, "HaStandbyClusterKey", value);
			}
		}

		public string HaStandbyHbaseFsDir
		{
			get
			{
				return haStandbyHbaseFsDir;
			}
			set	
			{
				haStandbyHbaseFsDir = value;
				DictionaryUtil.Add(QueryParameters, "HaStandbyHbaseFsDir", value);
			}
		}

		public string HaActiveHbaseFsDir
		{
			get
			{
				return haActiveHbaseFsDir;
			}
			set	
			{
				haActiveHbaseFsDir = value;
				DictionaryUtil.Add(QueryParameters, "HaActiveHbaseFsDir", value);
			}
		}

		public string HaActiveDBType
		{
			get
			{
				return haActiveDBType;
			}
			set	
			{
				haActiveDBType = value;
				DictionaryUtil.Add(QueryParameters, "HaActiveDBType", value);
			}
		}

		public string HaActivePassword
		{
			get
			{
				return haActivePassword;
			}
			set	
			{
				haActivePassword = value;
				DictionaryUtil.Add(QueryParameters, "HaActivePassword", value);
			}
		}

		public bool? IsActiveStandard
		{
			get
			{
				return isActiveStandard;
			}
			set	
			{
				isActiveStandard = value;
				DictionaryUtil.Add(QueryParameters, "IsActiveStandard", value.ToString());
			}
		}

		public string HaStandbyUser
		{
			get
			{
				return haStandbyUser;
			}
			set	
			{
				haStandbyUser = value;
				DictionaryUtil.Add(QueryParameters, "HaStandbyUser", value);
			}
		}

		public string HaActive
		{
			get
			{
				return haActive;
			}
			set	
			{
				haActive = value;
				DictionaryUtil.Add(QueryParameters, "HaActive", value);
			}
		}

		public string HaStandby
		{
			get
			{
				return haStandby;
			}
			set	
			{
				haStandby = value;
				DictionaryUtil.Add(QueryParameters, "HaStandby", value);
			}
		}

		public string HaStandbyHdfsUri
		{
			get
			{
				return haStandbyHdfsUri;
			}
			set	
			{
				haStandbyHdfsUri = value;
				DictionaryUtil.Add(QueryParameters, "HaStandbyHdfsUri", value);
			}
		}

		public string HaActiveVersion
		{
			get
			{
				return haActiveVersion;
			}
			set	
			{
				haActiveVersion = value;
				DictionaryUtil.Add(QueryParameters, "HaActiveVersion", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string HaStandbyDBType
		{
			get
			{
				return haStandbyDBType;
			}
			set	
			{
				haStandbyDBType = value;
				DictionaryUtil.Add(QueryParameters, "HaStandbyDBType", value);
			}
		}

		public string HaTables
		{
			get
			{
				return haTables;
			}
			set	
			{
				haTables = value;
				DictionaryUtil.Add(QueryParameters, "HaTables", value);
			}
		}

		public string HaActiveUser
		{
			get
			{
				return haActiveUser;
			}
			set	
			{
				haActiveUser = value;
				DictionaryUtil.Add(QueryParameters, "HaActiveUser", value);
			}
		}

        public override RelateDbForHBaseHaResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RelateDbForHBaseHaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
