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

namespace Aliyun.Acs.companyreg.Model.V20201022
{
	public class ListVoucherResponse : AcsResponse
	{

		private int? pageCount;

		private int? pageSize;

		private string requestId;

		private int? totalCount;

		private List<ListVoucher_ResultItem> result;

		public int? PageCount
		{
			get
			{
				return pageCount;
			}
			set	
			{
				pageCount = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

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

		public List<ListVoucher_ResultItem> Result
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

		public class ListVoucher_ResultItem
		{

			private long? createdStamp;

			private bool? hasEditAuthority;

			private long? id;

			private string period;

			private string refVoucherIds;

			private string refVoucherInfo;

			private int? uploadAttachmentCount;

			private long? voucherDate;

			private string voucherNo;

			private string voucherType;

			private string writtenPerson;

			private List<ListVoucher_DetailsItem> details;

			private ListVoucher_ExtAttributes extAttributes;

			private ListVoucher_VoucherTransCategoryId voucherTransCategoryId;

			public long? CreatedStamp
			{
				get
				{
					return createdStamp;
				}
				set	
				{
					createdStamp = value;
				}
			}

			public bool? HasEditAuthority
			{
				get
				{
					return hasEditAuthority;
				}
				set	
				{
					hasEditAuthority = value;
				}
			}

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

			public string Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public string RefVoucherIds
			{
				get
				{
					return refVoucherIds;
				}
				set	
				{
					refVoucherIds = value;
				}
			}

			public string RefVoucherInfo
			{
				get
				{
					return refVoucherInfo;
				}
				set	
				{
					refVoucherInfo = value;
				}
			}

			public int? UploadAttachmentCount
			{
				get
				{
					return uploadAttachmentCount;
				}
				set	
				{
					uploadAttachmentCount = value;
				}
			}

			public long? VoucherDate
			{
				get
				{
					return voucherDate;
				}
				set	
				{
					voucherDate = value;
				}
			}

			public string VoucherNo
			{
				get
				{
					return voucherNo;
				}
				set	
				{
					voucherNo = value;
				}
			}

			public string VoucherType
			{
				get
				{
					return voucherType;
				}
				set	
				{
					voucherType = value;
				}
			}

			public string WrittenPerson
			{
				get
				{
					return writtenPerson;
				}
				set	
				{
					writtenPerson = value;
				}
			}

			public List<ListVoucher_DetailsItem> Details
			{
				get
				{
					return details;
				}
				set	
				{
					details = value;
				}
			}

			public ListVoucher_ExtAttributes ExtAttributes
			{
				get
				{
					return extAttributes;
				}
				set	
				{
					extAttributes = value;
				}
			}

			public ListVoucher_VoucherTransCategoryId VoucherTransCategoryId
			{
				get
				{
					return voucherTransCategoryId;
				}
				set	
				{
					voucherTransCategoryId = value;
				}
			}

			public class ListVoucher_DetailsItem
			{

				private float? basePostedCreditor;

				private float? basePostedDebtor;

				private string comments;

				public float? BasePostedCreditor
				{
					get
					{
						return basePostedCreditor;
					}
					set	
					{
						basePostedCreditor = value;
					}
				}

				public float? BasePostedDebtor
				{
					get
					{
						return basePostedDebtor;
					}
					set	
					{
						basePostedDebtor = value;
					}
				}

				public string Comments
				{
					get
					{
						return comments;
					}
					set	
					{
						comments = value;
					}
				}
			}

			public class ListVoucher_ExtAttributes
			{

				private int? isSupervisor;

				private int? needCheckCreatorId;

				private int? updateAttachment;

				public int? IsSupervisor
				{
					get
					{
						return isSupervisor;
					}
					set	
					{
						isSupervisor = value;
					}
				}

				public int? NeedCheckCreatorId
				{
					get
					{
						return needCheckCreatorId;
					}
					set	
					{
						needCheckCreatorId = value;
					}
				}

				public int? UpdateAttachment
				{
					get
					{
						return updateAttachment;
					}
					set	
					{
						updateAttachment = value;
					}
				}
			}

			public class ListVoucher_VoucherTransCategoryId
			{

				private string name;

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
			}
		}
	}
}
