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
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20200201;

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
    public class ComposePlanogramPositionsRequest : RpcAcsRequest<ComposePlanogramPositionsResponse>
    {
        public ComposePlanogramPositionsRequest()
            : base("cloudesl", "2020-02-01", "ComposePlanogramPositions", "cloudesl", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string actionType;

		private string extraParams;

		private string storeId;

		private int? layer;

		private string layerOrigin;

		private bool? beAutoRefresh;

		private string shelf;

		private List<ShelfPositionInfo> shelfPositionInfos = new List<ShelfPositionInfo>(){ };

		public string ActionType
		{
			get
			{
				return actionType;
			}
			set	
			{
				actionType = value;
				DictionaryUtil.Add(BodyParameters, "ActionType", value);
			}
		}

		public string ExtraParams
		{
			get
			{
				return extraParams;
			}
			set	
			{
				extraParams = value;
				DictionaryUtil.Add(BodyParameters, "ExtraParams", value);
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
				DictionaryUtil.Add(BodyParameters, "StoreId", value);
			}
		}

		public int? Layer
		{
			get
			{
				return layer;
			}
			set	
			{
				layer = value;
				DictionaryUtil.Add(BodyParameters, "Layer", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "LayerOrigin", value);
			}
		}

		public bool? BeAutoRefresh
		{
			get
			{
				return beAutoRefresh;
			}
			set	
			{
				beAutoRefresh = value;
				DictionaryUtil.Add(BodyParameters, "BeAutoRefresh", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "Shelf", value);
			}
		}

		public List<ShelfPositionInfo> ShelfPositionInfos
		{
			get
			{
				return shelfPositionInfos;
			}

			set
			{
				shelfPositionInfos = value;
				for (int i = 0; i < shelfPositionInfos.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"ShelfPositionInfo." + (i + 1) + ".OffsetFrom", shelfPositionInfos[i].OffsetFrom);
					DictionaryUtil.Add(BodyParameters,"ShelfPositionInfo." + (i + 1) + ".Depth", shelfPositionInfos[i].Depth);
					DictionaryUtil.Add(BodyParameters,"ShelfPositionInfo." + (i + 1) + ".Column", shelfPositionInfos[i].Column);
					DictionaryUtil.Add(BodyParameters,"ShelfPositionInfo." + (i + 1) + ".Facing", shelfPositionInfos[i].Facing);
					DictionaryUtil.Add(BodyParameters,"ShelfPositionInfo." + (i + 1) + ".OffsetTo", shelfPositionInfos[i].OffsetTo);
					DictionaryUtil.Add(BodyParameters,"ShelfPositionInfo." + (i + 1) + ".ItemBarCode", shelfPositionInfos[i].ItemBarCode);
				}
			}
		}

		public class ShelfPositionInfo
		{

			private float? offsetFrom;

			private float? depth;

			private string column;

			private int? facing;

			private float? offsetTo;

			private string itemBarCode;

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
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ComposePlanogramPositionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ComposePlanogramPositionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
