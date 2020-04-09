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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class ListPersistentVolumeResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private int? pageSize;

		private int? pageNumber;

		private long? totalCount;

		private string errMsg;

		private List<ListPersistentVolume_PersistentVolumeDetail> data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
			}
		}

		public List<ListPersistentVolume_PersistentVolumeDetail> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListPersistentVolume_PersistentVolumeDetail
		{

			private string name;

			private string capacity;

			private string accessModes;

			private string reclaimPolicy;

			private string status;

			private string pvcName;

			private string mountDir;

			private string storageClass;

			private string reason;

			private string createTime;

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

			public string Capacity
			{
				get
				{
					return capacity;
				}
				set	
				{
					capacity = value;
				}
			}

			public string AccessModes
			{
				get
				{
					return accessModes;
				}
				set	
				{
					accessModes = value;
				}
			}

			public string ReclaimPolicy
			{
				get
				{
					return reclaimPolicy;
				}
				set	
				{
					reclaimPolicy = value;
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
				}
			}

			public string PvcName
			{
				get
				{
					return pvcName;
				}
				set	
				{
					pvcName = value;
				}
			}

			public string MountDir
			{
				get
				{
					return mountDir;
				}
				set	
				{
					mountDir = value;
				}
			}

			public string StorageClass
			{
				get
				{
					return storageClass;
				}
				set	
				{
					storageClass = value;
				}
			}

			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}
		}
	}
}
