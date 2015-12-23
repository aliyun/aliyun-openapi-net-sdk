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
    public class OpsDescribeSnapshotsRequest : RpcAcsRequest<OpsDescribeSnapshotsResponse>
    {
        public OpsDescribeSnapshotsRequest()
            : base("Ecs", "2015-11-01", "OpsDescribeSnapshots")
        {
        }

		private string regionNo;

		private int? pageNo;

		private int? pageSize;

		private long? resourceOwnerId;

		private string ecsInstanceId;

		private string snapshotIds;

		private string sourceDiskId;

		private string sourceDiskType;

		private bool? createFinished;

		private string snapshotTypes;

		private string fuzzySnapshotName;

		private string snapshotName;

		private string createTimeFrom;

		private string createTimeTo;

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

		public string SnapshotIds
		{
			get
			{
				return snapshotIds;
			}
			set	
			{
				snapshotIds = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotIds", value);
			}
		}

		public string SourceDiskId
		{
			get
			{
				return sourceDiskId;
			}
			set	
			{
				sourceDiskId = value;
				DictionaryUtil.Add(QueryParameters, "SourceDiskId", value);
			}
		}

		public string SourceDiskType
		{
			get
			{
				return sourceDiskType;
			}
			set	
			{
				sourceDiskType = value;
				DictionaryUtil.Add(QueryParameters, "SourceDiskType", value);
			}
		}

		public bool? CreateFinished
		{
			get
			{
				return createFinished;
			}
			set	
			{
				createFinished = value;
				DictionaryUtil.Add(QueryParameters, "CreateFinished", value.ToString());
			}
		}

		public string SnapshotTypes
		{
			get
			{
				return snapshotTypes;
			}
			set	
			{
				snapshotTypes = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotTypes", value);
			}
		}

		public string FuzzySnapshotName
		{
			get
			{
				return fuzzySnapshotName;
			}
			set	
			{
				fuzzySnapshotName = value;
				DictionaryUtil.Add(QueryParameters, "FuzzySnapshotName", value);
			}
		}

		public string SnapshotName
		{
			get
			{
				return snapshotName;
			}
			set	
			{
				snapshotName = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotName", value);
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

        public override OpsDescribeSnapshotsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return OpsDescribeSnapshotsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}