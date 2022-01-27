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
	public class RecognizeTicketInvoiceResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private RecognizeTicketInvoice_Data data;

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

		public RecognizeTicketInvoice_Data Data
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

		public class RecognizeTicketInvoice_Data
		{

			private long? count;

			private long? height;

			private long? width;

			private long? orgHeight;

			private long? orgWidth;

			private List<RecognizeTicketInvoice_ResultsItem> results;

			public long? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
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

			public List<RecognizeTicketInvoice_ResultsItem> Results
			{
				get
				{
					return results;
				}
				set	
				{
					results = value;
				}
			}

			public class RecognizeTicketInvoice_ResultsItem
			{

				private long? index;

				private string type;

				private List<RecognizeTicketInvoice_KeyValueInfosItem> keyValueInfos;

				private List<RecognizeTicketInvoice_SliceRectangleItem> sliceRectangle;

				private RecognizeTicketInvoice_Content content;

				public long? Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public List<RecognizeTicketInvoice_KeyValueInfosItem> KeyValueInfos
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

				public List<RecognizeTicketInvoice_SliceRectangleItem> SliceRectangle
				{
					get
					{
						return sliceRectangle;
					}
					set	
					{
						sliceRectangle = value;
					}
				}

				public RecognizeTicketInvoice_Content Content
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

				public class RecognizeTicketInvoice_KeyValueInfosItem
				{

					private string key;

					private string _value;

					private float? valueScore;

					private List<RecognizeTicketInvoice_ValuePositionsItem> valuePositions;

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

					public List<RecognizeTicketInvoice_ValuePositionsItem> ValuePositions
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

					public class RecognizeTicketInvoice_ValuePositionsItem
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

				public class RecognizeTicketInvoice_SliceRectangleItem
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

				public class RecognizeTicketInvoice_Content
				{

					private string invoiceCode;

					private string invoiceNumber;

					private string invoiceDate;

					private string antiFakeCode;

					private string payeeName;

					private string payeeRegisterNo;

					private string payerName;

					private string payerRegisterNo;

					private string sumAmount;

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

					public string InvoiceNumber
					{
						get
						{
							return invoiceNumber;
						}
						set	
						{
							invoiceNumber = value;
						}
					}

					public string InvoiceDate
					{
						get
						{
							return invoiceDate;
						}
						set	
						{
							invoiceDate = value;
						}
					}

					public string AntiFakeCode
					{
						get
						{
							return antiFakeCode;
						}
						set	
						{
							antiFakeCode = value;
						}
					}

					public string PayeeName
					{
						get
						{
							return payeeName;
						}
						set	
						{
							payeeName = value;
						}
					}

					public string PayeeRegisterNo
					{
						get
						{
							return payeeRegisterNo;
						}
						set	
						{
							payeeRegisterNo = value;
						}
					}

					public string PayerName
					{
						get
						{
							return payerName;
						}
						set	
						{
							payerName = value;
						}
					}

					public string PayerRegisterNo
					{
						get
						{
							return payerRegisterNo;
						}
						set	
						{
							payerRegisterNo = value;
						}
					}

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
				}
			}
		}
	}
}
