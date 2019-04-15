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
	public class DetectQRCodesResponse : AcsResponse
	{

		private string requestId;

		private List<DetectQRCodes_SuccessDetailsItem> successDetails;

		private List<DetectQRCodes_FailDetailsItem> failDetails;

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

		public List<DetectQRCodes_SuccessDetailsItem> SuccessDetails
		{
			get
			{
				return successDetails;
			}
			set	
			{
				successDetails = value;
			}
		}

		public List<DetectQRCodes_FailDetailsItem> FailDetails
		{
			get
			{
				return failDetails;
			}
			set	
			{
				failDetails = value;
			}
		}

		public class DetectQRCodes_SuccessDetailsItem
		{

			private string srcUri;

			private List<DetectQRCodes_QRCodesItem> qRCodes;

			public string SrcUri
			{
				get
				{
					return srcUri;
				}
				set	
				{
					srcUri = value;
				}
			}

			public List<DetectQRCodes_QRCodesItem> QRCodes
			{
				get
				{
					return qRCodes;
				}
				set	
				{
					qRCodes = value;
				}
			}

			public class DetectQRCodes_QRCodesItem
			{

				private string content;

				private DetectQRCodes_QRCodesRectangle qRCodesRectangle;

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public DetectQRCodes_QRCodesRectangle QRCodesRectangle
				{
					get
					{
						return qRCodesRectangle;
					}
					set	
					{
						qRCodesRectangle = value;
					}
				}

				public class DetectQRCodes_QRCodesRectangle
				{

					private string left;

					private string top;

					private string width;

					private string height;

					public string Left
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

					public string Top
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

					public string Width
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

					public string Height
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

		public class DetectQRCodes_FailDetailsItem
		{

			private string srcUri;

			private string errorCode;

			private string errorMessage;

			public string SrcUri
			{
				get
				{
					return srcUri;
				}
				set	
				{
					srcUri = value;
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
		}
	}
}
