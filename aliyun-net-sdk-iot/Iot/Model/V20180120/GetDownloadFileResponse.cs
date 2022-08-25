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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class GetDownloadFileResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private GetDownloadFile_Data data;

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

		public GetDownloadFile_Data Data
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

		public class GetDownloadFile_Data
		{

			private int? previewSize;

			private string csvUrl;

			private string datasetId;

			private string longJobId;

			private int? status;

			private long? beginTime;

			private long? endTime;

			private string resultDataInString;

			private bool? asyncExecute;

			private long? totalCount;

			private int? pageNo;

			private int? pageSize;

			private string csvUrl1;

			private string csvFileName;

			private List<GetDownloadFile_HeaderItem> header;

			private List<Dictionary<string, string>> result;

			private GetDownloadFile_QuerySetting querySetting;

			public int? PreviewSize
			{
				get
				{
					return previewSize;
				}
				set	
				{
					previewSize = value;
				}
			}

			public string CsvUrl
			{
				get
				{
					return csvUrl;
				}
				set	
				{
					csvUrl = value;
				}
			}

			public string DatasetId
			{
				get
				{
					return datasetId;
				}
				set	
				{
					datasetId = value;
				}
			}

			public string LongJobId
			{
				get
				{
					return longJobId;
				}
				set	
				{
					longJobId = value;
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

			public long? BeginTime
			{
				get
				{
					return beginTime;
				}
				set	
				{
					beginTime = value;
				}
			}

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string ResultDataInString
			{
				get
				{
					return resultDataInString;
				}
				set	
				{
					resultDataInString = value;
				}
			}

			public bool? AsyncExecute
			{
				get
				{
					return asyncExecute;
				}
				set	
				{
					asyncExecute = value;
				}
			}

			public long? TotalCount
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

			public int? PageNo
			{
				get
				{
					return pageNo;
				}
				set	
				{
					pageNo = value;
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

			public string CsvUrl1
			{
				get
				{
					return csvUrl1;
				}
				set	
				{
					csvUrl1 = value;
				}
			}

			public string CsvFileName
			{
				get
				{
					return csvFileName;
				}
				set	
				{
					csvFileName = value;
				}
			}

			public List<GetDownloadFile_HeaderItem> Header
			{
				get
				{
					return header;
				}
				set	
				{
					header = value;
				}
			}

			public List<Dictionary<string, string>> Result
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

			public GetDownloadFile_QuerySetting QuerySetting
			{
				get
				{
					return querySetting;
				}
				set	
				{
					querySetting = value;
				}
			}

			public class GetDownloadFile_HeaderItem
			{

				private string fieldName;

				private string alias;

				private string fieldType;

				private string typeClass;

				private string timeClass;

				private string geoClass;

				private string dimDateClass;

				public string FieldName
				{
					get
					{
						return fieldName;
					}
					set	
					{
						fieldName = value;
					}
				}

				public string Alias
				{
					get
					{
						return alias;
					}
					set	
					{
						alias = value;
					}
				}

				public string FieldType
				{
					get
					{
						return fieldType;
					}
					set	
					{
						fieldType = value;
					}
				}

				public string TypeClass
				{
					get
					{
						return typeClass;
					}
					set	
					{
						typeClass = value;
					}
				}

				public string TimeClass
				{
					get
					{
						return timeClass;
					}
					set	
					{
						timeClass = value;
					}
				}

				public string GeoClass
				{
					get
					{
						return geoClass;
					}
					set	
					{
						geoClass = value;
					}
				}

				public string DimDateClass
				{
					get
					{
						return dimDateClass;
					}
					set	
					{
						dimDateClass = value;
					}
				}
			}

			public class GetDownloadFile_QuerySetting
			{

				private List<GetDownloadFile_SelectedHeadersItem> selectedHeaders;

				private List<GetDownloadFile_AstExprItem> astExpr;

				public List<GetDownloadFile_SelectedHeadersItem> SelectedHeaders
				{
					get
					{
						return selectedHeaders;
					}
					set	
					{
						selectedHeaders = value;
					}
				}

				public List<GetDownloadFile_AstExprItem> AstExpr
				{
					get
					{
						return astExpr;
					}
					set	
					{
						astExpr = value;
					}
				}

				public class GetDownloadFile_SelectedHeadersItem
				{

					private string fieldName;

					private string alias;

					private string fieldType;

					private string timeClass;

					private string geoClass;

					private string dimDateClass;

					public string FieldName
					{
						get
						{
							return fieldName;
						}
						set	
						{
							fieldName = value;
						}
					}

					public string Alias
					{
						get
						{
							return alias;
						}
						set	
						{
							alias = value;
						}
					}

					public string FieldType
					{
						get
						{
							return fieldType;
						}
						set	
						{
							fieldType = value;
						}
					}

					public string TimeClass
					{
						get
						{
							return timeClass;
						}
						set	
						{
							timeClass = value;
						}
					}

					public string GeoClass
					{
						get
						{
							return geoClass;
						}
						set	
						{
							geoClass = value;
						}
					}

					public string DimDateClass
					{
						get
						{
							return dimDateClass;
						}
						set	
						{
							dimDateClass = value;
						}
					}
				}

				public class GetDownloadFile_AstExprItem
				{

					private string expr;

					private string exprType;

					public string Expr
					{
						get
						{
							return expr;
						}
						set	
						{
							expr = value;
						}
					}

					public string ExprType
					{
						get
						{
							return exprType;
						}
						set	
						{
							exprType = value;
						}
					}
				}
			}
		}
	}
}
