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
	public class DescribeCustomOcrTemplateResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeCustomOcrTemplate_OcrTemplate> ocrTemplateList;

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

		public int? TotalCount
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

		public List<DescribeCustomOcrTemplate_OcrTemplate> OcrTemplateList
		{
			get
			{
				return ocrTemplateList;
			}
			set	
			{
				ocrTemplateList = value;
			}
		}

		public class DescribeCustomOcrTemplate_OcrTemplate
		{

			private long? id;

			private string name;

			private string imgUrl;

			private int? status;

			private List<DescribeCustomOcrTemplate_Item> referArea;

			private List<DescribeCustomOcrTemplate_Item> recognizeArea;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

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

			public string ImgUrl
			{
				get
				{
					return imgUrl;
				}
				set	
				{
					imgUrl = value;
				}
			}

			public int? Status
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

			public List<DescribeCustomOcrTemplate_Item> ReferArea
			{
				get
				{
					return referArea;
				}
				set	
				{
					referArea = value;
				}
			}

			public List<DescribeCustomOcrTemplate_Item> RecognizeArea
			{
				get
				{
					return recognizeArea;
				}
				set	
				{
					recognizeArea = value;
				}
			}

			public class DescribeCustomOcrTemplate_Item
			{

				private string name;

				private int? x;

				private int? y;

				private int? width;

				private int? height;

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

				public int? X
				{
					get
					{
						return x;
					}
					set	
					{
						x = value;
					}
				}

				public int? Y
				{
					get
					{
						return y;
					}
					set	
					{
						y = value;
					}
				}

				public int? Width
				{
					get
					{
						return width;
					}
					set	
					{
						width = value;
					}
				}

				public int? Height
				{
					get
					{
						return height;
					}
					set	
					{
						height = value;
					}
				}
			}
		}
	}
}
