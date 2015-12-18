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
    public class OpsDescribeImagesRequest : RpcAcsRequest<OpsDescribeImagesResponse>
    {
        public OpsDescribeImagesRequest()
            : base("Ecs", "2015-11-01", "OpsDescribeImages")
        {
        }

		private string regionNo;

		private long? resourceOwnerId;

		private string imageIds;

		private string imageTypes;

		private string imageName;

		private string status;

		private string snapshotId;

		private string fuzzyImageName;

		private string createTimeFrom;

		private string createTimeTo;

		private bool? quoted;

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

		public string ImageIds
		{
			get
			{
				return imageIds;
			}
			set	
			{
				imageIds = value;
				DictionaryUtil.Add(QueryParameters, "ImageIds", value);
			}
		}

		public string ImageTypes
		{
			get
			{
				return imageTypes;
			}
			set	
			{
				imageTypes = value;
				DictionaryUtil.Add(QueryParameters, "ImageTypes", value);
			}
		}

		public string ImageName
		{
			get
			{
				return imageName;
			}
			set	
			{
				imageName = value;
				DictionaryUtil.Add(QueryParameters, "ImageName", value);
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

		public string FuzzyImageName
		{
			get
			{
				return fuzzyImageName;
			}
			set	
			{
				fuzzyImageName = value;
				DictionaryUtil.Add(QueryParameters, "FuzzyImageName", value);
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

		public bool? Quoted
		{
			get
			{
				return quoted;
			}
			set	
			{
				quoted = value;
				DictionaryUtil.Add(QueryParameters, "Quoted", value.ToString());
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

        public override OpsDescribeImagesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return OpsDescribeImagesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}