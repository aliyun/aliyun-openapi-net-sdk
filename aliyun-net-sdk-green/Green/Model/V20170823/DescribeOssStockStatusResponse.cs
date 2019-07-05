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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeOssStockStatusResponse : AcsResponse
	{

		private string requestId;

		private int? stockStatus;

		private string finishedTime;

		private int? imageTotalCount;

		private int? imagePornCount;

		private int? imageTerrorismCount;

		private int? videoTotalCount;

		private int? videoPornCount;

		private int? videoTerrorismCount;

		private List<DescribeOssStockStatus_Bucket> bucketList;

		private List<string> sceneList;

		private List<string> resouceTypeList;

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

		public int? StockStatus
		{
			get
			{
				return stockStatus;
			}
			set	
			{
				stockStatus = value;
			}
		}

		public string FinishedTime
		{
			get
			{
				return finishedTime;
			}
			set	
			{
				finishedTime = value;
			}
		}

		public int? ImageTotalCount
		{
			get
			{
				return imageTotalCount;
			}
			set	
			{
				imageTotalCount = value;
			}
		}

		public int? ImagePornCount
		{
			get
			{
				return imagePornCount;
			}
			set	
			{
				imagePornCount = value;
			}
		}

		public int? ImageTerrorismCount
		{
			get
			{
				return imageTerrorismCount;
			}
			set	
			{
				imageTerrorismCount = value;
			}
		}

		public int? VideoTotalCount
		{
			get
			{
				return videoTotalCount;
			}
			set	
			{
				videoTotalCount = value;
			}
		}

		public int? VideoPornCount
		{
			get
			{
				return videoPornCount;
			}
			set	
			{
				videoPornCount = value;
			}
		}

		public int? VideoTerrorismCount
		{
			get
			{
				return videoTerrorismCount;
			}
			set	
			{
				videoTerrorismCount = value;
			}
		}

		public List<DescribeOssStockStatus_Bucket> BucketList
		{
			get
			{
				return bucketList;
			}
			set	
			{
				bucketList = value;
			}
		}

		public List<string> SceneList
		{
			get
			{
				return sceneList;
			}
			set	
			{
				sceneList = value;
			}
		}

		public List<string> ResouceTypeList
		{
			get
			{
				return resouceTypeList;
			}
			set	
			{
				resouceTypeList = value;
			}
		}

		public class DescribeOssStockStatus_Bucket
		{

			private bool? selected;

			private string bucket;

			private List<string> prefixes;

			public bool? Selected
			{
				get
				{
					return selected;
				}
				set	
				{
					selected = value;
				}
			}

			public string Bucket
			{
				get
				{
					return bucket;
				}
				set	
				{
					bucket = value;
				}
			}

			public List<string> Prefixes
			{
				get
				{
					return prefixes;
				}
				set	
				{
					prefixes = value;
				}
			}
		}
	}
}
