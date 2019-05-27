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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class DetectImageTextsResponse : AcsResponse
	{

		private string requestId;

		private string imageUri;

		private List<DetectImageTexts_OCRItem> oCR;

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

		public string ImageUri
		{
			get
			{
				return imageUri;
			}
			set	
			{
				imageUri = value;
			}
		}

		public List<DetectImageTexts_OCRItem> OCR
		{
			get
			{
				return oCR;
			}
			set	
			{
				oCR = value;
			}
		}

		public class DetectImageTexts_OCRItem
		{

			private string oCRContents;

			private float? oCRConfidence;

			private DetectImageTexts_OCRBoundary oCRBoundary;

			public string OCRContents
			{
				get
				{
					return oCRContents;
				}
				set	
				{
					oCRContents = value;
				}
			}

			public float? OCRConfidence
			{
				get
				{
					return oCRConfidence;
				}
				set	
				{
					oCRConfidence = value;
				}
			}

			public DetectImageTexts_OCRBoundary OCRBoundary
			{
				get
				{
					return oCRBoundary;
				}
				set	
				{
					oCRBoundary = value;
				}
			}

			public class DetectImageTexts_OCRBoundary
			{

				private int? left;

				private int? top;

				private int? width;

				private int? height;

				public int? Left
				{
					get
					{
						return left;
					}
					set	
					{
						left = value;
					}
				}

				public int? Top
				{
					get
					{
						return top;
					}
					set	
					{
						top = value;
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
