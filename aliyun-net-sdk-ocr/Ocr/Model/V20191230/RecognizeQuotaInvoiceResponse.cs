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

namespace Aliyun.Acs.ocr.Model.V20191230
{
	public class RecognizeQuotaInvoiceResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private RecognizeQuotaInvoice_Data data;

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

		public RecognizeQuotaInvoice_Data Data
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

		public class RecognizeQuotaInvoice_Data
		{

			private long? angle;

			private long? height;

			private long? width;

			private long? orgHeight;

			private long? orgWidth;

			private List<RecognizeQuotaInvoice_KeyValueInfosItem> keyValueInfos;

			private RecognizeQuotaInvoice_Content content;

			public long? Angle
			{
				get
				{
					return angle;
				}
				set	
				{
					angle = value;
				}
			}

			public long? Height
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

			public long? Width
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

			public long? OrgHeight
			{
				get
				{
					return orgHeight;
				}
				set	
				{
					orgHeight = value;
				}
			}

			public long? OrgWidth
			{
				get
				{
					return orgWidth;
				}
				set	
				{
					orgWidth = value;
				}
			}

			public List<RecognizeQuotaInvoice_KeyValueInfosItem> KeyValueInfos
			{
				get
				{
					return keyValueInfos;
				}
				set	
				{
					keyValueInfos = value;
				}
			}

			public RecognizeQuotaInvoice_Content Content
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

			public class RecognizeQuotaInvoice_KeyValueInfosItem
			{

				private string key;

				private string _value;

				private float? valueScore;

				private List<RecognizeQuotaInvoice_ValuePositionsItem> valuePositions;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}

				public float? ValueScore
				{
					get
					{
						return valueScore;
					}
					set	
					{
						valueScore = value;
					}
				}

				public List<RecognizeQuotaInvoice_ValuePositionsItem> ValuePositions
				{
					get
					{
						return valuePositions;
					}
					set	
					{
						valuePositions = value;
					}
				}

				public class RecognizeQuotaInvoice_ValuePositionsItem
				{

					private long? x;

					private long? y;

					public long? X
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

					public long? Y
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
				}
			}

			public class RecognizeQuotaInvoice_Content
			{

				private string sumAmount;

				private string invoiceCode;

				private string invoiceNo;

				private string invoiceAmount;

				private string invoiceDetails;

				public string SumAmount
				{
					get
					{
						return sumAmount;
					}
					set	
					{
						sumAmount = value;
					}
				}

				public string InvoiceCode
				{
					get
					{
						return invoiceCode;
					}
					set	
					{
						invoiceCode = value;
					}
				}

				public string InvoiceNo
				{
					get
					{
						return invoiceNo;
					}
					set	
					{
						invoiceNo = value;
					}
				}

				public string InvoiceAmount
				{
					get
					{
						return invoiceAmount;
					}
					set	
					{
						invoiceAmount = value;
					}
				}

				public string InvoiceDetails
				{
					get
					{
						return invoiceDetails;
					}
					set	
					{
						invoiceDetails = value;
					}
				}
			}
		}
	}
}
