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

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
	public class DescribePlanogramPositionsResponse : AcsResponse
	{

		private string code;

		private string dynamicCode;

		private string dynamicMessage;

		private string errorCode;

		private string errorMessage;

		private string message;

		private string requestId;

		private string shelf;

		private string storeId;

		private bool? success;

		private string shelfType;

		private List<DescribePlanogramPositions_LayerInfo> layerInfos;

		public string Code
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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public string Shelf
		{
			get
			{
				return shelf;
			}
			set	
			{
				shelf = value;
			}
		}

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ShelfType
		{
			get
			{
				return shelfType;
			}
			set	
			{
				shelfType = value;
			}
		}

		public List<DescribePlanogramPositions_LayerInfo> LayerInfos
		{
			get
			{
				return layerInfos;
			}
			set	
			{
				layerInfos = value;
			}
		}

		public class DescribePlanogramPositions_LayerInfo
		{

			private int? layer;

			private string layerOrigin;

			private string railCode;

			private List<DescribePlanogramPositions_ShelfPositionInfo> shelfPositionInfos;

			public int? Layer
			{
				get
				{
					return layer;
				}
				set	
				{
					layer = value;
				}
			}

			public string LayerOrigin
			{
				get
				{
					return layerOrigin;
				}
				set	
				{
					layerOrigin = value;
				}
			}

			public string RailCode
			{
				get
				{
					return railCode;
				}
				set	
				{
					railCode = value;
				}
			}

			public List<DescribePlanogramPositions_ShelfPositionInfo> ShelfPositionInfos
			{
				get
				{
					return shelfPositionInfos;
				}
				set	
				{
					shelfPositionInfos = value;
				}
			}

			public class DescribePlanogramPositions_ShelfPositionInfo
			{

				private string column;

				private float? depth;

				private int? facing;

				private string itemBarCode;

				private string itemTitle;

				private float? offsetFrom;

				private float? offsetTo;

				public string Column
				{
					get
					{
						return column;
					}
					set	
					{
						column = value;
					}
				}

				public float? Depth
				{
					get
					{
						return depth;
					}
					set	
					{
						depth = value;
					}
				}

				public int? Facing
				{
					get
					{
						return facing;
					}
					set	
					{
						facing = value;
					}
				}

				public string ItemBarCode
				{
					get
					{
						return itemBarCode;
					}
					set	
					{
						itemBarCode = value;
					}
				}

				public string ItemTitle
				{
					get
					{
						return itemTitle;
					}
					set	
					{
						itemTitle = value;
					}
				}

				public float? OffsetFrom
				{
					get
					{
						return offsetFrom;
					}
					set	
					{
						offsetFrom = value;
					}
				}

				public float? OffsetTo
				{
					get
					{
						return offsetTo;
					}
					set	
					{
						offsetTo = value;
					}
				}
			}
		}
	}
}
