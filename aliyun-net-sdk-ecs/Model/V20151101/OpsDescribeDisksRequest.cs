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
    public class OpsDescribeDisksRequest : RpcAcsRequest<OpsDescribeDisksResponse>
    {
        public OpsDescribeDisksRequest()
            : base("Ecs", "2015-11-01", "OpsDescribeDisks")
        {
        }

		private string regionNo;

		private string izNo;

		private string ecsInstanceId;

		private string diskIds;

		private string status;

		private string excludeStatus;

		private bool? active;

		private string snapshotId;

		private string imageId;

		private bool? portable;

		private bool? deleteWithInstance;

		private bool? deleteAutoSnapshot;

		private bool? enableAutoSnapshot;

		private string diskType;

		private string diskCategory;

		private string fuzzyDiskName;

		private string createTimeFrom;

		private string createTimeTo;

		private long? resourceOwnerId;

		private int? pageNo;

		private int? pageSize;

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

		public string DiskIds
		{
			get
			{
				return diskIds;
			}
			set	
			{
				diskIds = value;
				DictionaryUtil.Add(QueryParameters, "DiskIds", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public string ExcludeStatus
		{
			get
			{
				return excludeStatus;
			}
			set	
			{
				excludeStatus = value;
				DictionaryUtil.Add(QueryParameters, "ExcludeStatus", value);
			}
		}

		public bool? Active
		{
			get
			{
				return active;
			}
			set	
			{
				active = value;
				DictionaryUtil.Add(QueryParameters, "Active", value.ToString());
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

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
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

		public string DiskType
		{
			get
			{
				return diskType;
			}
			set	
			{
				diskType = value;
				DictionaryUtil.Add(QueryParameters, "DiskType", value);
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

		public string FuzzyDiskName
		{
			get
			{
				return fuzzyDiskName;
			}
			set	
			{
				fuzzyDiskName = value;
				DictionaryUtil.Add(QueryParameters, "FuzzyDiskName", value);
			}
		}

		public string CreateTimeFrom
		{
			get
			{
				return createTimeFrom;
			}
			set	
			{
				createTimeFrom = value;
				DictionaryUtil.Add(QueryParameters, "CreateTimeFrom", value);
			}
		}

		public string CreateTimeTo
		{
			get
			{
				return createTimeTo;
			}
			set	
			{
				createTimeTo = value;
				DictionaryUtil.Add(QueryParameters, "CreateTimeTo", value);
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

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(QueryParameters, "PageNo", value.ToString());
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

        public override OpsDescribeDisksResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return OpsDescribeDisksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}