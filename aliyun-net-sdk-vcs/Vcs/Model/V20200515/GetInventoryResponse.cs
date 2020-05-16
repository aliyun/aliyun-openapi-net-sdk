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

namespace Aliyun.Acs.Vcs.Model.V20200515
{
	public class GetInventoryResponse : AcsResponse
	{

		private bool? success;

		private GetInventory_Data data;

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

		public GetInventory_Data Data
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

		public class GetInventory_Data
		{

			private List<GetInventory_ResultObjectItem> resultObject;

			public List<GetInventory_ResultObjectItem> ResultObject
			{
				get
				{
					return resultObject;
				}
				set	
				{
					resultObject = value;
				}
			}

			public class GetInventory_ResultObjectItem
			{

				private string buyerId;

				private string commodityCode;

				private string currentInventory;

				private string validEndTime;

				private string validStartTime;

				private string instanceId;

				private string inventoryId;

				public string BuyerId
				{
					get
					{
						return buyerId;
					}
					set	
					{
						buyerId = value;
					}
				}

				public string CommodityCode
				{
					get
					{
						return commodityCode;
					}
					set	
					{
						commodityCode = value;
					}
				}

				public string CurrentInventory
				{
					get
					{
						return currentInventory;
					}
					set	
					{
						currentInventory = value;
					}
				}

				public string ValidEndTime
				{
					get
					{
						return validEndTime;
					}
					set	
					{
						validEndTime = value;
					}
				}

				public string ValidStartTime
				{
					get
					{
						return validStartTime;
					}
					set	
					{
						validStartTime = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public string InventoryId
				{
					get
					{
						return inventoryId;
					}
					set	
					{
						inventoryId = value;
					}
				}
			}
		}
	}
}
