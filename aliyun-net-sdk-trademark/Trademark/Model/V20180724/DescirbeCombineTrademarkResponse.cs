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

namespace Aliyun.Acs.Trademark.Model.V20180724
{
	public class DescirbeCombineTrademarkResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNumber;

		private int? currentPageNumber;

		private int? pageSize;

		private int? totalPageNumber;

		private bool? prePage;

		private bool? nextPage;

		private List<DescirbeCombineTrademark_Trademark> data;

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

		public int? TotalItemNumber
		{
			get
			{
				return totalItemNumber;
			}
			set	
			{
				totalItemNumber = value;
			}
		}

		public int? CurrentPageNumber
		{
			get
			{
				return currentPageNumber;
			}
			set	
			{
				currentPageNumber = value;
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

		public int? TotalPageNumber
		{
			get
			{
				return totalPageNumber;
			}
			set	
			{
				totalPageNumber = value;
			}
		}

		public bool? PrePage
		{
			get
			{
				return prePage;
			}
			set	
			{
				prePage = value;
			}
		}

		public bool? NextPage
		{
			get
			{
				return nextPage;
			}
			set	
			{
				nextPage = value;
			}
		}

		public List<DescirbeCombineTrademark_Trademark> Data
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

		public class DescirbeCombineTrademark_Trademark
		{

			private string indexId;

			private string name;

			private string registrationNumber;

			private string classification;

			private string applyDate;

			private string ownerName;

			private string ownerEnName;

			private string image;

			private string preAnnNumber;

			private string regAnnNumber;

			private string preAnnDate;

			private string regAnnDate;

			private string lawFinalStatus;

			private string lastProcedureStatus;

			private string share;

			private string ownerAddress;

			private string ownerEnAddress;

			private string exclusiveDateLimit;

			private string agency;

			private string productDescription;

			private string similarGroup;

			private string registrationType;

			private int? onSale;

			private string status;

			private string priorityDate;

			private string intlRegDate;

			private string subsequentDesignationDate;

			private string firstAnnoNumber;

			private string firstAnnoType;

			private string secondAnnoNumber;

			private string secondAnnoType;

			private List<DescirbeCombineTrademark_AnnouncementListItem> announcementList;

			private List<DescirbeCombineTrademark_ProcedureList> procedures;

			public string IndexId
			{
				get
				{
					return indexId;
				}
				set	
				{
					indexId = value;
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

			public string RegistrationNumber
			{
				get
				{
					return registrationNumber;
				}
				set	
				{
					registrationNumber = value;
				}
			}

			public string Classification
			{
				get
				{
					return classification;
				}
				set	
				{
					classification = value;
				}
			}

			public string ApplyDate
			{
				get
				{
					return applyDate;
				}
				set	
				{
					applyDate = value;
				}
			}

			public string OwnerName
			{
				get
				{
					return ownerName;
				}
				set	
				{
					ownerName = value;
				}
			}

			public string OwnerEnName
			{
				get
				{
					return ownerEnName;
				}
				set	
				{
					ownerEnName = value;
				}
			}

			public string Image
			{
				get
				{
					return image;
				}
				set	
				{
					image = value;
				}
			}

			public string PreAnnNumber
			{
				get
				{
					return preAnnNumber;
				}
				set	
				{
					preAnnNumber = value;
				}
			}

			public string RegAnnNumber
			{
				get
				{
					return regAnnNumber;
				}
				set	
				{
					regAnnNumber = value;
				}
			}

			public string PreAnnDate
			{
				get
				{
					return preAnnDate;
				}
				set	
				{
					preAnnDate = value;
				}
			}

			public string RegAnnDate
			{
				get
				{
					return regAnnDate;
				}
				set	
				{
					regAnnDate = value;
				}
			}

			public string LawFinalStatus
			{
				get
				{
					return lawFinalStatus;
				}
				set	
				{
					lawFinalStatus = value;
				}
			}

			public string LastProcedureStatus
			{
				get
				{
					return lastProcedureStatus;
				}
				set	
				{
					lastProcedureStatus = value;
				}
			}

			public string Share
			{
				get
				{
					return share;
				}
				set	
				{
					share = value;
				}
			}

			public string OwnerAddress
			{
				get
				{
					return ownerAddress;
				}
				set	
				{
					ownerAddress = value;
				}
			}

			public string OwnerEnAddress
			{
				get
				{
					return ownerEnAddress;
				}
				set	
				{
					ownerEnAddress = value;
				}
			}

			public string ExclusiveDateLimit
			{
				get
				{
					return exclusiveDateLimit;
				}
				set	
				{
					exclusiveDateLimit = value;
				}
			}

			public string Agency
			{
				get
				{
					return agency;
				}
				set	
				{
					agency = value;
				}
			}

			public string ProductDescription
			{
				get
				{
					return productDescription;
				}
				set	
				{
					productDescription = value;
				}
			}

			public string SimilarGroup
			{
				get
				{
					return similarGroup;
				}
				set	
				{
					similarGroup = value;
				}
			}

			public string RegistrationType
			{
				get
				{
					return registrationType;
				}
				set	
				{
					registrationType = value;
				}
			}

			public int? OnSale
			{
				get
				{
					return onSale;
				}
				set	
				{
					onSale = value;
				}
			}

			public string Status
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

			public string PriorityDate
			{
				get
				{
					return priorityDate;
				}
				set	
				{
					priorityDate = value;
				}
			}

			public string IntlRegDate
			{
				get
				{
					return intlRegDate;
				}
				set	
				{
					intlRegDate = value;
				}
			}

			public string SubsequentDesignationDate
			{
				get
				{
					return subsequentDesignationDate;
				}
				set	
				{
					subsequentDesignationDate = value;
				}
			}

			public string FirstAnnoNumber
			{
				get
				{
					return firstAnnoNumber;
				}
				set	
				{
					firstAnnoNumber = value;
				}
			}

			public string FirstAnnoType
			{
				get
				{
					return firstAnnoType;
				}
				set	
				{
					firstAnnoType = value;
				}
			}

			public string SecondAnnoNumber
			{
				get
				{
					return secondAnnoNumber;
				}
				set	
				{
					secondAnnoNumber = value;
				}
			}

			public string SecondAnnoType
			{
				get
				{
					return secondAnnoType;
				}
				set	
				{
					secondAnnoType = value;
				}
			}

			public List<DescirbeCombineTrademark_AnnouncementListItem> AnnouncementList
			{
				get
				{
					return announcementList;
				}
				set	
				{
					announcementList = value;
				}
			}

			public List<DescirbeCombineTrademark_ProcedureList> Procedures
			{
				get
				{
					return procedures;
				}
				set	
				{
					procedures = value;
				}
			}

			public class DescirbeCombineTrademark_AnnouncementListItem
			{

				private string annNumber;

				private string annTypeCode;

				private string annTypeName;

				private string annDate;

				private string imageUrl;

				private string originalImageUrl;

				public string AnnNumber
				{
					get
					{
						return annNumber;
					}
					set	
					{
						annNumber = value;
					}
				}

				public string AnnTypeCode
				{
					get
					{
						return annTypeCode;
					}
					set	
					{
						annTypeCode = value;
					}
				}

				public string AnnTypeName
				{
					get
					{
						return annTypeName;
					}
					set	
					{
						annTypeName = value;
					}
				}

				public string AnnDate
				{
					get
					{
						return annDate;
					}
					set	
					{
						annDate = value;
					}
				}

				public string ImageUrl
				{
					get
					{
						return imageUrl;
					}
					set	
					{
						imageUrl = value;
					}
				}

				public string OriginalImageUrl
				{
					get
					{
						return originalImageUrl;
					}
					set	
					{
						originalImageUrl = value;
					}
				}
			}

			public class DescirbeCombineTrademark_ProcedureList
			{

				private string procedureCode;

				private string procedureName;

				private string procedureStep;

				private string procedureResult;

				private string procedureDate;

				public string ProcedureCode
				{
					get
					{
						return procedureCode;
					}
					set	
					{
						procedureCode = value;
					}
				}

				public string ProcedureName
				{
					get
					{
						return procedureName;
					}
					set	
					{
						procedureName = value;
					}
				}

				public string ProcedureStep
				{
					get
					{
						return procedureStep;
					}
					set	
					{
						procedureStep = value;
					}
				}

				public string ProcedureResult
				{
					get
					{
						return procedureResult;
					}
					set	
					{
						procedureResult = value;
					}
				}

				public string ProcedureDate
				{
					get
					{
						return procedureDate;
					}
					set	
					{
						procedureDate = value;
					}
				}
			}
		}
	}
}
