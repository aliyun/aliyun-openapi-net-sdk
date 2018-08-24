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
using System.Collections.Generic;

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

			private string result;

			private DetectQRCodes_QRCodesRectangle qRCodesRectangle;

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

			public string Result
			{
				get
				{
					return result;
				}
				set	
				{
					result = value;
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

		public class DetectQRCodes_FailDetailsItem
		{

			private string srcUri;

			private string reason;

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

			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}
		}
	}
}