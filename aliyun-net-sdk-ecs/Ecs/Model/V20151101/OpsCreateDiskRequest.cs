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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20151101;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20151101
{
    public class OpsCreateDiskRequest : RpcAcsRequest<OpsCreateDiskResponse>
    {
        public OpsCreateDiskRequest()
            : base("Ecs", "2015-11-01", "OpsCreateDisk")
        {
        }

		private string regionNo;

		private string izNo;

		private string diskCategory;

		private int? diskSize;

		private string diskName;

		private string diskDesc;

		private string snapshotId;

		private bool? portable;

		private bool? deleteWithInstance;

		private bool? deleteAutoSnapshot;

		private bool? enableAutoSnapshot;

		private string mountPoint;

		private string ecsInstanceId;

		private int? iopsSize;

		private int? bpsSize;

		private long? resourceOwnerId;

		public string RegionNo
		{
			get
			{
				return regionNo;
			}
			set	
			{
				regionNo = value;
				DictionaryUtil.Add(QueryParameters, "RegionNo", value);
			}
		}

		public string IzNo
		{
			get
			{
				return izNo;
			}
			set	
			{
				izNo = value;
				DictionaryUtil.Add(QueryParameters, "IzNo", value);
			}
		}

		public string DiskCategory
		{
			get
			{
				return diskCategory;
			}
			set	
			{
				diskCategory = value;
				DictionaryUtil.Add(QueryParameters, "DiskCategory", value);
			}
		}

		public int? DiskSize
		{
			get
			{
				return diskSize;
			}
			set	
			{
				diskSize = value;
				DictionaryUtil.Add(QueryParameters, "DiskSize", value.ToString());
			}
		}

		public string DiskName
		{
			get
			{
				return diskName;
			}
			set	
			{
				diskName = value;
				DictionaryUtil.Add(QueryParameters, "DiskName", value);
			}
		}

		public string DiskDesc
		{
			get
			{
				return diskDesc;
			}
			set	
			{
				diskDesc = value;
				DictionaryUtil.Add(QueryParameters, "DiskDesc", value);
			}
		}

		public string SnapshotId
		{
			get
			{
				return snapshotId;
			}
			set	
			{
				snapshotId = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotId", value);
			}
		}

		public bool? Portable
		{
			get
			{
				return portable;
			}
			set	
			{
				portable = value;
				DictionaryUtil.Add(QueryParameters, "Portable", value.ToString());
			}
		}

		public bool? DeleteWithInstance
		{
			get
			{
				return deleteWithInstance;
			}
			set	
			{
				deleteWithInstance = value;
				DictionaryUtil.Add(QueryParameters, "DeleteWithInstance", value.ToString());
			}
		}

		public bool? DeleteAutoSnapshot
		{
			get
			{
				return deleteAutoSnapshot;
			}
			set	
			{
				deleteAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "DeleteAutoSnapshot", value.ToString());
			}
		}

		public bool? EnableAutoSnapshot
		{
			get
			{
				return enableAutoSnapshot;
			}
			set	
			{
				enableAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "EnableAutoSnapshot", value.ToString());
			}
		}

		public string MountPoint
		{
			get
			{
				return mountPoint;
			}
			set	
			{
				mountPoint = value;
				DictionaryUtil.Add(QueryParameters, "MountPoint", value);
			}
		}

		public string EcsInstanceId
		{
			get
			{
				return ecsInstanceId;
			}
			set	
			{
				ecsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "EcsInstanceId", value);
			}
		}

		public int? IopsSize
		{
			get
			{
				return iopsSize;
			}
			set	
			{
				iopsSize = value;
				DictionaryUtil.Add(QueryParameters, "IopsSize", value.ToString());
			}
		}

		public int? BpsSize
		{
			get
			{
				return bpsSize;
			}
			set	
			{
				bpsSize = value;
				DictionaryUtil.Add(QueryParameters, "BpsSize", value.ToString());
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

        public override OpsCreateDiskResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return OpsCreateDiskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}