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
	public class RecognizeTaxiInvoiceResponse : AcsResponse
	{

		private string requestId;

		private RecognizeTaxiInvoice_Data data;

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

		public RecognizeTaxiInvoice_Data Data
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

		public class RecognizeTaxiInvoice_Data
		{

			private List<RecognizeTaxiInvoice_Invoice> invoices;

			public List<RecognizeTaxiInvoice_Invoice> Invoices
			{
				get
				{
					return invoices;
				}
				set	
				{
					invoices = value;
				}
			}

			public class RecognizeTaxiInvoice_Invoice
			{

				private int? rotateType;

				private List<RecognizeTaxiInvoice_Item> items;

				private RecognizeTaxiInvoice_InvoiceRoi invoiceRoi;

				public int? RotateType
				{
					get
					{
						return rotateType;
					}
					set	
					{
						rotateType = value;
					}
				}

				public List<RecognizeTaxiInvoice_Item> Items
				{
					get
					{
						return items;
					}
					set	
					{
						items = value;
					}
				}

				public RecognizeTaxiInvoice_InvoiceRoi InvoiceRoi
				{
					get
					{
						return invoiceRoi;
					}
					set	
					{
						invoiceRoi = value;
					}
				}

				public class RecognizeTaxiInvoice_Item
				{

					private string text;

					private RecognizeTaxiInvoice_ItemRoi itemRoi;

					public string Text
					{
						get
						{
							return text;
						}
						set	
						{
							text = value;
						}
					}

					public RecognizeTaxiInvoice_ItemRoi ItemRoi
					{
						get
						{
							return itemRoi;
						}
						set	
						{
							itemRoi = value;
						}
					}

					public class RecognizeTaxiInvoice_ItemRoi
					{

						private float? angle;

						private RecognizeTaxiInvoice_Center center;

						private RecognizeTaxiInvoice_Size size;

						public float? Angle
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

						public RecognizeTaxiInvoice_Center Center
						{
							get
							{
								return center;
							}
							set	
							{
								center = value;
							}
						}

						public RecognizeTaxiInvoice_Size Size
						{
							get
							{
								return size;
							}
							set	
							{
								size = value;
							}
						}

						public class RecognizeTaxiInvoice_Center
						{

							private float? x;

							private float? y;

							public float? X
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

							public float? Y
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

						public class RecognizeTaxiInvoice_Size
						{

							private float? h;

							private float? w;

							public float? H
							{
								get
								{
									return h;
								}
								set	
								{
									h = value;
								}
							}

							public float? W
							{
								get
								{
									return w;
								}
								set	
								{
									w = value;
								}
							}
						}
					}
				}

				public class RecognizeTaxiInvoice_InvoiceRoi
				{

					private float? h;

					private float? w;

					private float? x;

					private float? y;

					public float? H
					{
						get
						{
							return h;
						}
						set	
						{
							h = value;
						}
					}

					public float? W
					{
						get
						{
							return w;
						}
						set	
						{
							w = value;
						}
					}

					public float? X
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

					public float? Y
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
		}
	}
}
