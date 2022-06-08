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
	public class GetItemMaterialResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string message;

		private string errorCode;

		private string errorMessage;

		private string code;

		private string dynamicCode;

		private string dynamicMessage;

		private GetItemMaterial_MaterialInfo materialInfo;

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

		public GetItemMaterial_MaterialInfo MaterialInfo
		{
			get
			{
				return materialInfo;
			}
			set	
			{
				materialInfo = value;
			}
		}

		public class GetItemMaterial_MaterialInfo
		{

			private string itemName;

			private string barCode;

			private string gmtCreate;

			private string materialName;

			private string materialId;

			private string materialFeatureA;

			private string materialFeatureB;

			private string materialFeatureC;

			private string materialFeatureD;

			public string ItemName
			{
				get
				{
					return itemName;
				}
				set	
				{
					itemName = value;
				}
			}

			public string BarCode
			{
				get
				{
					return barCode;
				}
				set	
				{
					barCode = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string MaterialName
			{
				get
				{
					return materialName;
				}
				set	
				{
					materialName = value;
				}
			}

			public string MaterialId
			{
				get
				{
					return materialId;
				}
				set	
				{
					materialId = value;
				}
			}

			public string MaterialFeatureA
			{
				get
				{
					return materialFeatureA;
				}
				set	
				{
					materialFeatureA = value;
				}
			}

			public string MaterialFeatureB
			{
				get
				{
					return materialFeatureB;
				}
				set	
				{
					materialFeatureB = value;
				}
			}

			public string MaterialFeatureC
			{
				get
				{
					return materialFeatureC;
				}
				set	
				{
					materialFeatureC = value;
				}
			}

			public string MaterialFeatureD
			{
				get
				{
					return materialFeatureD;
				}
				set	
				{
					materialFeatureD = value;
				}
			}
		}
	}
}
