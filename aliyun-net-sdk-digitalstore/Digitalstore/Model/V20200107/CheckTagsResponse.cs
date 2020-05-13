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

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
	public class CheckTagsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<CheckTags_CheckTagResultBiz> checkResult;

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

		public List<CheckTags_CheckTagResultBiz> CheckResult
		{
			get
			{
				return checkResult;
			}
			set	
			{
				checkResult = value;
			}
		}

		public class CheckTags_CheckTagResultBiz
		{

			private string tagValue;

			private string tagId;

			private string barcode;

			private bool? beValid;

			private bool? beBound;

			private bool? beOrderTag;

			private bool? beBoxing;

			private string tagPositionType;

			private string styleId;

			private string styleCode;

			private string styleName;

			private string sKUId;

			private string sKUName;

			private string colorCode;

			private string colorName;

			private string sizeCode;

			private string sizeName;

			private string tagPositionId;

			private string brandCode;

			private string brandName;

			private string caseId;

			private string sizeId;

			private string colorId;

			private string caseCode;

			private string brandId;

			public string TagValue
			{
				get
				{
					return tagValue;
				}
				set	
				{
					tagValue = value;
				}
			}

			public string TagId
			{
				get
				{
					return tagId;
				}
				set	
				{
					tagId = value;
				}
			}

			public string Barcode
			{
				get
				{
					return barcode;
				}
				set	
				{
					barcode = value;
				}
			}

			public bool? BeValid
			{
				get
				{
					return beValid;
				}
				set	
				{
					beValid = value;
				}
			}

			public bool? BeBound
			{
				get
				{
					return beBound;
				}
				set	
				{
					beBound = value;
				}
			}

			public bool? BeOrderTag
			{
				get
				{
					return beOrderTag;
				}
				set	
				{
					beOrderTag = value;
				}
			}

			public bool? BeBoxing
			{
				get
				{
					return beBoxing;
				}
				set	
				{
					beBoxing = value;
				}
			}

			public string TagPositionType
			{
				get
				{
					return tagPositionType;
				}
				set	
				{
					tagPositionType = value;
				}
			}

			public string StyleId
			{
				get
				{
					return styleId;
				}
				set	
				{
					styleId = value;
				}
			}

			public string StyleCode
			{
				get
				{
					return styleCode;
				}
				set	
				{
					styleCode = value;
				}
			}

			public string StyleName
			{
				get
				{
					return styleName;
				}
				set	
				{
					styleName = value;
				}
			}

			public string SKUId
			{
				get
				{
					return sKUId;
				}
				set	
				{
					sKUId = value;
				}
			}

			public string SKUName
			{
				get
				{
					return sKUName;
				}
				set	
				{
					sKUName = value;
				}
			}

			public string ColorCode
			{
				get
				{
					return colorCode;
				}
				set	
				{
					colorCode = value;
				}
			}

			public string ColorName
			{
				get
				{
					return colorName;
				}
				set	
				{
					colorName = value;
				}
			}

			public string SizeCode
			{
				get
				{
					return sizeCode;
				}
				set	
				{
					sizeCode = value;
				}
			}

			public string SizeName
			{
				get
				{
					return sizeName;
				}
				set	
				{
					sizeName = value;
				}
			}

			public string TagPositionId
			{
				get
				{
					return tagPositionId;
				}
				set	
				{
					tagPositionId = value;
				}
			}

			public string BrandCode
			{
				get
				{
					return brandCode;
				}
				set	
				{
					brandCode = value;
				}
			}

			public string BrandName
			{
				get
				{
					return brandName;
				}
				set	
				{
					brandName = value;
				}
			}

			public string CaseId
			{
				get
				{
					return caseId;
				}
				set	
				{
					caseId = value;
				}
			}

			public string SizeId
			{
				get
				{
					return sizeId;
				}
				set	
				{
					sizeId = value;
				}
			}

			public string ColorId
			{
				get
				{
					return colorId;
				}
				set	
				{
					colorId = value;
				}
			}

			public string CaseCode
			{
				get
				{
					return caseCode;
				}
				set	
				{
					caseCode = value;
				}
			}

			public string BrandId
			{
				get
				{
					return brandId;
				}
				set	
				{
					brandId = value;
				}
			}
		}
	}
}
